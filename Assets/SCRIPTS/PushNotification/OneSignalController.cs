using UnityEngine;
using System.Collections;

public class OneSignalController : MonoBehaviour {
    private const string ONE_SIGNAL_APP_ID = "93f1c30e-3d2b-4eab-8a98-2272e5008e6a";
    private const string GOOGLE_SENDER_ID = "958369594751";

    void Start() {
        // Enable line below to enable logging if you are having issues setting up OneSignal. (logLevel, visualLogLevel)
        //OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.INFO, OneSignal.LOG_LEVEL.INFO);

        OneSignal.StartInit(ONE_SIGNAL_APP_ID, GOOGLE_SENDER_ID)
          .HandleNotificationOpened(HandleNotificationOpened)
          .EndInit();

        // Sync hashed email if you have a login system or collect it.
        //   Will be used to reach the user at the most optimal time of day.
        // OneSignal.syncHashedEmail(userEmail);
    }

    // Gets called when the player opens the notification.
    private static void HandleNotificationOpened(OSNotificationOpenedResult result) {
    }
}
