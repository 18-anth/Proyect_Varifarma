using System;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Storage;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace clínica_Varifarmas
{
    public static class FirebaseAppConfig
    {
        public static void InitializeFirebaseApp()
        {
            // Ruta al archivo JSON con las credenciales de servicio
            string pathToCredentials = "C://Users/antho/source/repos/clínica_Varifarmas/varifarma-proyect-firebase-adminsdk-ncfhc-3074de82c6.json";

            // Inicializar el SDK de Firebase
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(pathToCredentials),
                
            });
            Console.WriteLine("Connect FireBase");
        }
    }
}

