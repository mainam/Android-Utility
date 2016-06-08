package ngocnam.info.androidutility;

import java.util.ArrayList;

import android.app.Service;
import android.content.ContentProviderOperation;
import android.content.ContentProviderResult;
import android.content.Intent;
import android.content.OperationApplicationException;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.IBinder;
import android.os.Looper;
import android.os.Message;
import android.os.RemoteException;
import android.provider.CallLog;
import android.provider.ContactsContract;
import android.provider.Telephony;
import android.provider.ContactsContract.Data;
import android.provider.ContactsContract.RawContacts;
import android.provider.ContactsContract.CommonDataKinds.Phone;
import android.provider.ContactsContract.CommonDataKinds.StructuredName;
import android.util.Log;
import android.widget.Toast;

public class AndroidUtility_Service extends Service {

	private Looper mServiceLooper;
	private ServiceHandler mServiceHandler;
	private String TAG = "AndroidUtility";

	// Handler that receives messages from the thread
	private final class ServiceHandler extends Handler {
		public ServiceHandler(Looper looper) {
			super(looper);
		}

		@Override
		public void handleMessage(Message msg) {

			synchronized (this) {
				try {
					// wait(endTime - System.currentTimeMillis());
					String text = msg.obj.toString();
					if (text.startsWith("CALLLOG:".toLowerCase())) {
						int type = 0;
						int number;
						try {
							text = text.replace("CALLLOG:".toLowerCase(), "");
							if (text.startsWith("MISSED_TYPE:".toLowerCase())) {
								text = text.replace(
										"MISSED_TYPE:".toLowerCase(), "");
								type = CallLog.Calls.MISSED_TYPE;
							} else {
								if (text.startsWith("INCOMING_TYPE:"
										.toLowerCase())) {
									text = text.replace(
											"INCOMING_TYPE:".toLowerCase(), "");
									type = CallLog.Calls.INCOMING_TYPE;
								} else {
									if (text.startsWith("OUTGOING_TYPE:"
											.toLowerCase())) {
										text = text.replace(
												"OUTGOING_TYPE:".toLowerCase(),
												"");
										type = CallLog.Calls.OUTGOING_TYPE;
									} else {
										throw new Exception();
									}
								}
							}
							number = Integer.parseInt(text);
							if (number < 0 && number > 5000)
								throw new Exception();

							ImportCallLog(number, "0987654321", type);
						} catch (Exception e) {
							Log.d(TAG, "Error: Parameters invalid");
							// TODO: handle exception
						}
					} else if (text.startsWith("CONTACT:".toLowerCase())) {
						text = text.replace("CONTACT:".toLowerCase(), "");
						int number = Integer.parseInt(text);
						if (number < 0 && number > 5000)
							throw new Exception();
						ImportContact(number);
					} else if (text.startsWith("SMS_SENT:".toLowerCase())) {
						text = text.replace("SMS_SENT:".toLowerCase(), "");
						int number = Integer.parseInt(text);
						if (number < 0 && number > 5000)
							throw new Exception();
						ImportSMS(number, 1, "0987654321");
					} else if (text.startsWith("SMS_INBOX:".toLowerCase())) {
						text = text.replace("SMS_INBOX:".toLowerCase(), "");
						int number = Integer.parseInt(text);
						if (number < 0 && number > 5000)
							throw new Exception();
						ImportSMS(number, 0, "0987654321");
					} else {
						throw new Exception();
					}
				} catch (Exception e) {
					Log.d(TAG, "Error: Parameters invalid");

				}
			}

			stopSelf(msg.arg1);
		}
	}

	@Override
	public void onCreate() {
		// Start up the thread running the service. Note that we create a
		// separate thread because the service normally runs in the process's
		// main thread, which we don't want to block. We also make it
		// background priority so CPU-intensive work will not disrupt our UI.
		HandlerThread thread = new HandlerThread("ServiceStartArguments",
				android.os.Process.THREAD_PRIORITY_BACKGROUND);
		thread.start();

		// Get the HandlerThread's Looper and use it for our Handler
		mServiceLooper = thread.getLooper();
		mServiceHandler = new ServiceHandler(mServiceLooper);
	}

	void ImportSMS(int number, int type, String templateNumber) {
		String typeimport = (type == 0 ? "inbox" : "sent");
		if (number == 0)
			return;

		Log.d(TAG, "Import " + number + " , " + type);
		ArrayList<ContentProviderOperation> ops = new ArrayList<ContentProviderOperation>();
		Uri uri = Uri.parse("content://sms/" + typeimport);
		try {
			for (int i = 0; i < number; i++) {
				Log.d(TAG, "Import " + i + " , " + typeimport);
				ops.add(ContentProviderOperation
						.newInsert(uri)
						.withValue("address", templateNumber + (i + 1))
						.withValue(
								"body",
								"Tôi yêu em : đến nay chừng có thể. Ngọn lửa tình chưa hẳn đã tàn phai. Nhưng không thể để em bận lòng thêm nữa, Hay hồn em phải đượm bóng u hoài.  www.wikipedia.org 0906009012 】〓〔〕■□▣▤▥▦▧▨▩▲△▶▷▼▽◀◁◆◇◈○◎●◐◑★☆☎☏☜☞♀♂♠♡♣♤♥♧此修改加入的進展現有的 ▷▼▽◀◁◆◇◈○◎●◐◑★☆☎☏☜☞♀♂♠♡♣♤♥♧♨♩♪♬♭〈〉《》「©¨¢£¤¥¦§ª«¬®¯°±²³´µ¶•¸¹º»¼½¾¿ˆˇː˘˙˚˛˜˝")
						.build());

				if (ops.size() > 100) {
					Log.d(TAG, "Commit :" + ops.size() + " sms (" + typeimport
							+ ")");
					ContentProviderResult[] res = getContentResolver()
							.applyBatch("sms", ops);
					Log.d(TAG, "Commit :" + ops.size() + " sms  (" + typeimport
							+ ") success");
					ops.clear();
				}
			}
			if (ops.size() > 0) {
				Log.d(TAG, "Commit :" + ops.size() + " sms (" + typeimport
						+ ")");
				ContentProviderResult[] res = getContentResolver().applyBatch(
						"sms", ops);
				Log.d(TAG, "Commit :" + ops.size() + " sms  (" + typeimport
						+ ") success");
				ops.clear();
			}
		} catch (RemoteException e) {
			// TODO Auto-generated catch block

			Log.d(TAG, "error: " + e.getMessage());
			e.printStackTrace();
		} catch (OperationApplicationException e) {
			// TODO Auto-generated catch block
			Log.d(TAG, "error: " + e.getMessage());
			e.printStackTrace();
		}
	}

	void ImportContact(Integer... urls) {
		String[] firstnames = { "PHAM  ", "MAI ", "NGUYEN ", "TANG ", "VU ",
				"LE ", "DAO ", "TRAN ", "DUONG ", "HOANG ", "TRUONG ", "DO ",
				"DINH ", "VUONG ", "CHU ", "DANG ", "BUI ", "HO ", "THAN ",
				"DOAN ", "HAN ", "DAM ", "NHAT ", "CAO ", "TON " };
		String[] middernames = { "NGOC ", " ", "THAT ", "THI ", "VAN ",
				"DANG ", "TRUNG ", "TUAN ", "THANH ", "XUAN ", "DINH ", "HAI ",
				"XUAN ", "DUC ", "ANH ", "VIET ", "KHANH ", "TRUONG ",
				"PHUONG ", "VIET ", "MY ", "THE ", "THUY ", "QUANG ", "DUC " };
		String[] lastnames = { "QUET", "TUNG", "NAM ", "LOI ", "TU ", "HANH ",
				"VAN ", "HUNG ", "TAM ", "HIEU ", "NHAT ", "TINH ", "DUNG ",
				"BINH ", "TOAN ", "MINH ", "NGUYET ", "YEN ", "QUAN ", "DONG ",
				"HUNG ", "TUAN ", "DOANG ", "BAC ", "TUNG ", "HAN ", "DUONG " };
		int total = urls[0];
		if (total == 0)
			return;
		int count = 0;
		Boolean isbreak = false;
		Log.d(TAG, "Start import " + total + " contact");
		ArrayList<ContentProviderOperation> ops = new ArrayList<ContentProviderOperation>();
		int temp = 0;

		for (int i = 0; i < 50; i++) {
			for (String string : firstnames) {
				for (String string2 : middernames) {
					for (String string3 : lastnames) {

						temp++;
						count++;

						int rawContactInsertIndex = ops.size();

						ops.add(ContentProviderOperation
								.newInsert(RawContacts.CONTENT_URI)
								.withValue(RawContacts.ACCOUNT_TYPE, null)
								.withValue(RawContacts.ACCOUNT_NAME, null)
								.build());

						// Phone Number1
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.NUMBER, "0987654321" + count)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.TYPE, Phone.TYPE_HOME).build());
						// Phone Number2
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.NUMBER, "098765432221" + count)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.TYPE, Phone.TYPE_MOBILE)
								.build());
						// Phone Number3
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.NUMBER, "+84765432221" + count)
								.withValue(Data.MIMETYPE,
										Phone.CONTENT_ITEM_TYPE)
								.withValue(Phone.TYPE, Phone.TYPE_WORK_MOBILE)
								.build());
						
						
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(Data.MIMETYPE,
										StructuredName.CONTENT_ITEM_TYPE)
								.withValue(
										StructuredName.DISPLAY_NAME,
										string + string2 + string3
												+ (i == 0 ? "" : i + ""))
								.build());
						// Email details1
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Email.DATA,
										"sample.email." + count + "@gmail.com")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Email.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Email.TYPE,
										ContactsContract.CommonDataKinds.Email.TYPE_WORK)
								.build());
						// Email details1
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Email.DATA,
										"sample.email2." + count + "@gmail.com")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Email.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Email.TYPE,
										ContactsContract.CommonDataKinds.Email.TYPE_HOME)
								.build());
						// Email details1
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Email.DATA,
										"sample.email3." + count + "@gmail.com")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Email.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Email.TYPE,
										ContactsContract.CommonDataKinds.Email.TYPE_MOBILE)
								.build());
						// event
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Event.DATA,
										"Thum 7 Jan 2016")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Event.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Event.TYPE,
										ContactsContract.CommonDataKinds.Event.TYPE_BIRTHDAY)
								.build());
						// web blog
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Website.DATA,
										"https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=9&ved=0ahUKEwiH-pCAqJ_LAhWEKZQKHdmkBcsQFghLMAg&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FAndroid_(operating_system)&usg=AFQjCNEHEl9ALYSbXSuqbbyVwRXSXnAVfw&sig2=BJUtZ66TrY2t4LmWw7Ep7Q&bvm=bv.115339255,d.dGY&cad=rja")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Website.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Website.TYPE,
										ContactsContract.CommonDataKinds.Website.TYPE_BLOG)
								.build());
						// web TYPE_HOME
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Website.DATA,
										"https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=10&cad=rja&uact=8&ved=0ahUKEwiH-pCAqJ_LAhWEKZQKHdmkBcsQqQIIXDAJ&url=http%3A%2F%2Fwww.androidpolice.com%2F2016%2F02%2F29%2Fexclusive-an-early-look-at-android-ns-redesigned-notification-shade-and-quick-settings-panel%2F&usg=AFQjCNEiyT_WlypohjAbqVXEUEgP-U1q6Q&sig2=b-Nn64A80ZqBZrG17fqcoQ&bvm=bv.115339255,d.dGY")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Website.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Website.TYPE,
										ContactsContract.CommonDataKinds.Website.TYPE_HOME)
								.build());
						// web TYPE_HOMEPAGE
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Website.DATA,
										"https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwiH-pCAqJ_LAhWEKZQKHdmkBcsQFggcMAA&url=https%3A%2F%2Fwww.android.com%2F&usg=AFQjCNEA66KaJHosX2e9eHE4O7kGxfIKrg&sig2=-tv0B-oZKzEHUcg5I8B4jg&bvm=bv.115339255,d.dGY")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Website.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Website.TYPE,
										ContactsContract.CommonDataKinds.Website.TYPE_HOMEPAGE)
								.build());
						
						
						// Email details1
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Event.DATA,
										"11/12/2015")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Event.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Event.TYPE,
										ContactsContract.CommonDataKinds.Event.TYPE_OTHER)
								.build());
						// nick name
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										ContactsContract.CommonDataKinds.Nickname.DATA,
										"Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Nickname.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Nickname.TYPE,
										ContactsContract.CommonDataKinds.Nickname.TYPE_MAIDEN_NAME)
								.build());
						// Postal Address

						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(
										ContactsContract.Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.POBOX,
										"Postbox")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.STREET,
										"street 12,street 12,street 12,street 12")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.CITY,
										"city city city city ")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.REGION,
										"region")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.POSTCODE,
										"postcode")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.COUNTRY,
										"country")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.StructuredPostal.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.StructuredPostal.TYPE,
										"3")

								.build());

						// Organization details
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Organization.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Organization.COMPANY,
										"SVMC")
								.withValue(
										ContactsContract.CommonDataKinds.Organization.DEPARTMENT,
										"S/W Quality Analysis P")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Organization.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Organization.TITLE,
										"Senior Engineer")

								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Organization.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Organization.TYPE,
										"0")

								.build());
						// IM details
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Im.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Im.DATA,
										"ImName")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Im.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Im.DATA5,
										"2").build());
						// IM details
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Im.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Im.DATA,
										"qwerqwaerqwerqwe")
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Im.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Im.DATA5,
										"3").build());
						// Note details
						ops.add(ContentProviderOperation
								.newInsert(ContactsContract.Data.CONTENT_URI)
								.withValueBackReference(Data.RAW_CONTACT_ID,
										rawContactInsertIndex)
								.withValue(
										Data.MIMETYPE,
										ContactsContract.CommonDataKinds.Note.CONTENT_ITEM_TYPE)
								.withValue(
										ContactsContract.CommonDataKinds.Note.NOTE,
										"Å‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â‰ à»àº¥àº´à»€àº§àº™àº—àºµà»ˆà»€àºšàº´à»ˆàº‡àºšà»à»ˆà»€àº«àº±àº™à»ƒàº«à»‰àºàº±àºšàºœàº¹à»‰à»ƒàºŠà»‰à»„àº”à»‰Â©Â¢Â£Â¤ìžì—ê²ŒaÃ¡áº­áº¡Æ°Æ¡á»±á»£ì°¸ê³ ë¡œëª¨ë°”ì¼í‚¤ë³´ë“œì˜ì˜ì—­ì€ì‹¤ì œê¸°êµ¬ë¥¼ìž¥ì°©~unÃ ysá»­aÄ‘á»•ibá»•sungvÃ oBá»™luáº­thiá»‡nhÃ nhvá»sá»±tiáº¿nbá»™á»Ÿmá»—ipháº§nsáº½gÃ¢yralogickhÃ´ngcáº§nthiáº¿tlÃ háº¯t~!@#$%^&*()_+`Â©Â¨Â¢Â£Â¤Â¥Â¦Â§ÂªÂ«Â¬Â®Â¯Â°Â±Â²Â³Â´ÂµÂ¶â€¢Â¸Â¹ÂºÂ»Â¼Â½Â¾Â¿Ë†Ë‡ËË˜Ë™ËšË›ËœËÃ€ÃÃ‚ÃƒÃ„Ã…Ã†Ã‡ÃˆÃ‰ÃŠÃ‹ÃŒÃÃŽÃÃÃ‘Ã’Ã“Ã”Ã•Ã–Ã—Ã˜Ã¹ÃºÃ»Ã¼Ã½Ã¾Ã¿Ä‘Ä¦Ä§Ä±Ä²Ä³Ä¸Ä¿Å€ÅÅ‚Å‰ÅŠÅ‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â… â…¡â…¢â…£â…¤â…¥â…¦â…§â…¨â…©â…°â…±â…²â…³â…´â…µâ…¶â…·â…¸â…¹âˆ€âˆ‚âˆƒâˆˆâˆ‡âˆ‹âˆâˆ‘âˆšâˆâˆžâˆ âˆ¥âˆ§âˆ¨âˆ©âˆªâˆ«âˆ¬âˆ®âˆ½â‰’â‰ â‰¡â‰¤â‰¥â‰ªâ‰«âŠ‚âŠƒâŠ†âŠ‡âŠ™âŠ¥âŒ’Å‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â‰ à»àº¥àº´à»€àº§àº™àº—àºµà»ˆà»€àºšàº´à»ˆàº‡àºšà»à»ˆà»€àº«àº±àº™à»ƒàº«à»‰àºàº±àºšàºœàº¹à»‰à»ƒàºŠà»‰à»„àº”à»‰Â©Â¢Â£Â¤ìžì—ê²ŒaÃ¡áº­áº¡Æ°Æ¡á»±á»£ì°¸ê³ ë¡œëª¨ë°”ì¼í‚¤ë³´ë“œì˜ì˜ì—­ì€ì‹¤ì œê¸°êµ¬ë¥¼ìž¥ì°©~unÃ ysá»­aÄ‘á»•ibá»•sungvÃ oBá»™luáº­thiá»‡nhÃ nhvá»sá»±tiáº¿nbá»™á»Ÿmá»—ipháº§nsáº½gÃ¢yralogickhÃ´ngcáº§nthiáº¿tlÃ háº¯t~!@#$%^&*()_+`Â©Â¨Â¢Â£Â¤Â¥Â¦Â§ÂªÂ«Â¬Â®Â¯Â°Â±Â²Â³Â´ÂµÂ¶â€¢Â¸Â¹ÂºÂ»Â¼Â½Â¾Â¿Ë†Ë‡ËË˜Ë™ËšË›ËœËÃ€ÃÃ‚ÃƒÃ„Ã…Ã†Ã‡ÃˆÃ‰ÃŠÃ‹ÃŒÃÃŽÃÃÃ‘Ã’Ã“Ã”Ã•Ã–Ã—Ã˜Ã¹ÃºÃ»Ã¼Ã½Ã¾Ã¿Ä‘Ä¦Ä§Ä±Ä²Ä³Ä¸Ä¿Å€ÅÅ‚Å‰ÅŠÅ‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â… â…¡â…¢â…£â…¤â…¥â…¦â…§â…¨â…©â…°â…±â…²â…³â…´â…µâ…¶â…·â…¸â…¹âˆ€âˆ‚âˆƒâˆˆâˆ‡âˆ‹âˆâˆ‘âˆšâˆâˆžâˆ âˆ¥âˆ§âˆ¨âˆ©âˆªâˆ«âˆ¬âˆ®âˆ½â‰’â‰ â‰¡â‰¤â‰¥â‰ªâ‰«âŠ‚âŠƒâŠ†âŠ‡âŠ™âŠ¥âŒ’Å‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â‰ à»àº¥àº´à»€àº§àº™àº—àºµà»ˆà»€àºšàº´à»ˆàº‡àºšà»à»ˆà»€àº«àº±àº™à»ƒàº«à»‰àºàº±àºšàºœàº¹à»‰à»ƒàºŠà»‰à»„àº”à»‰Â©Â¢Â£Â¤ìžì—ê²ŒaÃ¡áº­áº¡Æ°Æ¡á»±á»£ì°¸ê³ ë¡œëª¨ë°”ì¼í‚¤ë³´ë“œì˜ì˜ì—­ì€ì‹¤ì œê¸°êµ¬ë¥¼ìž¥ì°©~unÃ ysá»­aÄ‘á»•ibá»•sungvÃ oBá»™luáº­thiá»‡nhÃ nhvá»sá»±tiáº¿nbá»™á»Ÿmá»—ipháº§nsáº½gÃ¢yralogickhÃ´ngcáº§nthiáº¿tlÃ háº¯t~!@#$%^&*()_+`Â©Â¨Â¢Â£Â¤Â¥Â¦Â§ÂªÂ«Â¬Â®Â¯Â°Â±Â²Â³Â´ÂµÂ¶â€¢Â¸Â¹ÂºÂ»Â¼Â½Â¾Â¿Ë†Ë‡ËË˜Ë™ËšË›ËœËÃ€ÃÃ‚ÃƒÃ„Ã…Ã†Ã‡ÃˆÃ‰ÃŠÃ‹ÃŒÃÃŽÃÃÃ‘Ã’Ã“Ã”Ã•Ã–Ã—Ã˜Ã¹ÃºÃ»Ã¼Ã½Ã¾Ã¿Ä‘Ä¦Ä§Ä±Ä²Ä³Ä¸Ä¿Å€ÅÅ‚Å‰ÅŠÅ‹Å’Å Å“Å¡Å¦Å§Å¸Å½Å¾Æ’Î‘Î’Î“Î”Î•Î–Î—Î˜Î™ÎšÎ›ÎœÎÎžÎŸÎ Î¡Î£Î¤Î¥Î¦Î§Î¨Î©Î±Î²Î³Î´ÎµÎ¶Î·Î¸Î¹ÎºÎ»Î¼Î½Î¾Î¿Ï€ÏÏƒÏ„Ï…Ï†Ï‡ÏˆÏ‰â… â…¡â…¢â…£â…¤â…¥â…¦â…§â…¨â…©â…°â…±â…²â…³â…´â…µâ…¶â…·â…¸â…¹âˆ€âˆ‚âˆƒâˆˆâˆ‡âˆ‹âˆâˆ‘âˆšâˆâˆžâˆ âˆ¥âˆ§âˆ¨âˆ©âˆªâˆ«âˆ¬âˆ®âˆ½â‰’â‰ â‰¡â‰¤â‰¥â‰ªâ‰«âŠ‚âŠƒâŠ†âŠ‡âŠ™âŠ¥âŒ’")
								.build());

						Log.d(TAG, "Import contact: " + count);

						if (temp == 25) {
							try {
								temp = 0;
								Log.d(TAG, "Commit :" + count + " contact ");
								ContentProviderResult[] res = getContentResolver()
										.applyBatch(ContactsContract.AUTHORITY,
												ops);
								Log.d(TAG, "Commit :" + count
										+ " contact success");
								ops.clear();
							} catch (RemoteException e) {
								// TODO Auto-generated catch block
								e.printStackTrace();
								Log.d(TAG, "Commit :" + count
										+ " contact  fail");
							} catch (OperationApplicationException e) {
								// TODO Auto-generated catch block
								e.printStackTrace();
								Log.d(TAG, "Commit :" + count + " contact fail");
							}

						}

						if (count >= total) {
							isbreak = true;
							break;
						}
					}
					if (isbreak)
						break;
				}
				if (isbreak)
					break;
			}
			if (isbreak)
				break;
		}

		if (temp != 0)
			try {
				temp = 0;
				Log.d(TAG, "Commit :" + count + " contact");
				ContentProviderResult[] res = getContentResolver().applyBatch(
						ContactsContract.AUTHORITY, ops);
				Log.d(TAG, "Commit :" + count + "contact  success");
				ops.clear();
			} catch (RemoteException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				Log.d(TAG, "Commit :" + count + "contact  fail");
			} catch (OperationApplicationException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				Log.d(TAG, "Commit :" + count + " contact fail");
			}

	}

	void ImportCallLog(int Total, String templateNumber, int Type) {
		if (Total == 0)
			return;
		ArrayList<ContentProviderOperation> ops = new ArrayList<ContentProviderOperation>();
		for (int i = 0; i < Total; i++) {

			ops.add(ContentProviderOperation
					.newInsert(CallLog.Calls.CONTENT_URI)
					.withValue(CallLog.Calls.NUMBER, templateNumber + i)
					.withValue(CallLog.Calls.DATE, System.currentTimeMillis())
					.withValue(CallLog.Calls.DURATION, 0)
					.withValue(CallLog.Calls.TYPE, Type)
					.withValue(CallLog.Calls.NEW, 1)
					.withValue(CallLog.Calls.CACHED_NAME, "")
					.withValue(CallLog.Calls.CACHED_NUMBER_TYPE, 0)
					.withValue(CallLog.Calls.CACHED_NUMBER_LABEL, "").build());
			String text = "Insert calllog["
					+ ((Type == CallLog.Calls.INCOMING_TYPE) ? "INCOMING_TYPE"
							: (Type == CallLog.Calls.OUTGOING_TYPE) ? "OUTGOING_TYPE"
									: "MISSED_TYPE") + "]";
			Log.d(TAG, text + ": " + i);
		}

		try {
			Log.d(TAG, "Submiting " + Total + " log");
			ContentProviderResult[] res = getContentResolver().applyBatch(
					CallLog.AUTHORITY, ops);
			Log.d(TAG, "Submited " + Total + " log success");
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			Log.d(TAG, "Submited " + Total + " log failed");
		} catch (OperationApplicationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			Log.d(TAG, "Submited " + Total + " log failed");

		}

	}

	@Override
	public int onStartCommand(Intent intent, int flags, int startId) {

		// For each start request, send a message to start a job and deliver the
		// start ID so we know which request we're stopping when we finish the
		// job
		String text = "";
		try {
			text = intent.getStringExtra("arg").trim().toLowerCase();
			if (null == text || text.isEmpty())
				throw new Exception();
			Log.d(TAG, text);

		} catch (Exception e) {
			Log.d(TAG, "Error: Parameters invalid");
		}

		Message msg = mServiceHandler.obtainMessage();
		msg.obj = text;
		msg.arg1 = startId;
		mServiceHandler.sendMessage(msg);

		// If we get killed, after returning from here, restart
		return START_STICKY;
	}

	@Override
	public IBinder onBind(Intent intent) {
		// We don't provide binding, so return null
		return null;
	}

	@Override
	public void onDestroy() {
	}

}
