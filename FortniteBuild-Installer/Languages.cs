using System.Collections.Generic;

namespace FortniteBuildInstaller
{
    public static class Languages
    {
        public static Dictionary<string, string> French = new Dictionary<string, string>
        {
            { "welcome",@"
___________            __         .__  __           __________      .__.__       .___ .___                 __         .__  .__                
\_   _____/___________/  |_  ____ |__|/  |_  ____   \______   \__ __|__|  |    __| _/ |   | ____   _______/  |______  |  | |  |   ___________ 
 |    __)/  _ \_  __ \   __\/    \|  \   __\/ __ \   |    |  _/  |  \  |  |   / __ |  |   |/    \ /  ___/\   __\__  \ |  | |  | _/ __ \_  __ \
 |     \(  <_> )  | \/|  | |   |  \  ||  | \  ___/   |    |   \  |  /  |  |__/ /_/ |  |   |   |  \\___ \  |  |  / __ \|  |_|  |_\  ___/|  | \/
 \___  / \____/|__|   |__| |___|  /__||__|  \___  >  |______  /____/|__|____/\____ |  |___|___|  /____  > |__| (____  /____/____/\___  >__|   
     \/                         \/              \/          \/                    \/           \/     \/            \/               \/        " },

            { "available_builds", "Voici la liste des builds disponibles :" },
            { "enter_choice", "Entrez le numéro du build que vous souhaitez télécharger :" },
            { "invalid_choice", "Choix invalide. Veuillez réessayer." },
            { "build_choice", "Vous avez choisi :" },
            { "enter_path", "Entrez le chemin où vous souhaitez installer ce build :" },
            { "invalid_path", "Chemin invalide. Veuillez réessayer." },
            { "downloading", "Téléchargement en cours dans :" },
            { "download_success", "Téléchargement terminé avec succès!" },
            { "download_error", "Erreur lors du téléchargement ou de l'extraction :" },
            { "extracting", "Début de l'extraction..." },
            { "extract_success", "Extraction terminée avec succès!" },
            { "press_key", "Appuyez sur une touche pour quitter." },
        };

        public static Dictionary<string, string> English = new Dictionary<string, string>
        {
            { "welcome",@"
___________            __         .__  __           __________      .__.__       .___ .___                 __         .__  .__                
\_   _____/___________/  |_  ____ |__|/  |_  ____   \______   \__ __|__|  |    __| _/ |   | ____   _______/  |______  |  | |  |   ___________ 
 |    __)/  _ \_  __ \   __\/    \|  \   __\/ __ \   |    |  _/  |  \  |  |   / __ |  |   |/    \ /  ___/\   __\__  \ |  | |  | _/ __ \_  __ \
 |     \(  <_> )  | \/|  | |   |  \  ||  | \  ___/   |    |   \  |  /  |  |__/ /_/ |  |   |   |  \\___ \  |  |  / __ \|  |_|  |_\  ___/|  | \/
 \___  / \____/|__|   |__| |___|  /__||__|  \___  >  |______  /____/|__|____/\____ |  |___|___|  /____  > |__| (____  /____/____/\___  >__|   
     \/                         \/              \/          \/                    \/           \/     \/            \/               \/        " },
            { "available_builds", "Here is the list of available builds:" },
            { "enter_choice", "Enter the number of the build you want to download:" },
            { "invalid_choice", "Invalid choice. Please try again." },
            { "build_choice", "You have selected :" },
            { "enter_path", "Enter the path where you want to install this build:" },
            { "invalid_path", "Invalid path. Please try again." },
            { "downloading", "Downloading to:" },
            { "download_success", "Download completed successfully!" },
            { "download_error", "Error during download or extraction:" },
            { "extracting", "Starting extraction..." },
            { "extract_success", "Extraction completed successfully!" },
            { "press_key", "Press any key to exit." },
        };

        public static Dictionary<string, string> German = new Dictionary<string, string>
        {
            { "welcome",@"
___________            __         .__  __           __________      .__.__       .___ .___                 __         .__  .__                
\_   _____/___________/  |_  ____ |__|/  |_  ____   \______   \__ __|__|  |    __| _/ |   | ____   _______/  |______  |  | |  |   ___________ 
 |    __)/  _ \_  __ \   __\/    \|  \   __\/ __ \   |    |  _/  |  \  |  |   / __ |  |   |/    \ /  ___/\   __\__  \ |  | |  | _/ __ \_  __ \
 |     \(  <_> )  | \/|  | |   |  \  ||  | \  ___/   |    |   \  |  /  |  |__/ /_/ |  |   |   |  \\___ \  |  |  / __ \|  |_|  |_\  ___/|  | \/
 \___  / \____/|__|   |__| |___|  /__||__|  \___  >  |______  /____/|__|____/\____ |  |___|___|  /____  > |__| (____  /____/____/\___  >__|   
     \/                         \/              \/          \/                    \/           \/     \/            \/               \/        " },
            { "available_builds", "Hier ist die Liste der verfügbaren Builds:" },
            { "enter_choice", "Geben Sie die Nummer des Builds ein, den Sie herunterladen möchten:" },
            { "invalid_choice", "Ungültige Wahl. Bitte versuchen Sie es erneut." },
            { "build_choice", "Sie haben gewählt :" },
            { "enter_path", "Geben Sie den Pfad ein, an dem Sie diesen Build installieren möchten:" },
            { "invalid_path", "Ungültiger Pfad. Bitte versuchen Sie es erneut." },
            { "downloading", "Herunterladen nach:" },
            { "download_success", "Download erfolgreich abgeschlossen!" },
            { "download_error", "Fehler beim Herunterladen oder Extrahieren:" },
            { "extracting", "Extraktion beginnt..." },
            { "extract_success", "Extraktion erfolgreich abgeschlossen!" },
            { "press_key", "Drücken Sie eine Taste, um zu beenden." },
        };

        // Thx chatgpt
        public static Dictionary<string, string> Spanish = new Dictionary<string, string>
        {
            { "welcome",@"
___________            __         .__  __           __________      .__.__       .___ .___                 __         .__  .__                
\_   _____/___________/  |_  ____ |__|/  |_  ____   \______   \__ __|__|  |    __| _/ |   | ____   _______/  |______  |  | |  |   ___________ 
 |    __)/  _ \_  __ \   __\/    \|  \   __\/ __ \   |    |  _/  |  \  |  |   / __ |  |   |/    \ /  ___/\   __\__  \ |  | |  | _/ __ \_  __ \
 |     \(  <_> )  | \/|  | |   |  \  ||  | \  ___/   |    |   \  |  /  |  |__/ /_/ |  |   |   |  \\___ \  |  |  / __ \|  |_|  |_\  ___/|  | \/
 \___  / \____/|__|   |__| |___|  /__||__|  \___  >  |______  /____/|__|____/\____ |  |___|___|  /____  > |__| (____  /____/____/\___  >__|   
     \/                         \/              \/          \/                    \/           \/     \/            \/               \/        " },
            { "available_builds", "Aquí está la lista de builds disponibles:" },
            { "enter_choice", "Ingresa el número del build que deseas descargar:" },
            { "invalid_choice", "Elección inválida. Por favor, intenta de nuevo." },
            { "build_choice", "Has seleccionado :" },
            { "enter_path", "Ingresa la ruta donde deseas instalar este build:" },
            { "invalid_path", "Ruta inválida. Por favor, intenta de nuevo." },
            { "downloading", "Descargando a:" },
            { "download_success", "¡Descarga completada con éxito!" },
            { "download_error", "Error durante la descarga o extracción:" },
            { "extracting", "Iniciando extracción..." },
            { "extract_success", "¡Extracción completada con éxito!" },
            { "press_key", "Presiona cualquier tecla para salir." },
        };

        // Thx chatgpt
        public static Dictionary<string, string> Italian = new Dictionary<string, string>
        {
            { "welcome",@"
___________            __         .__  __           __________      .__.__       .___ .___                 __         .__  .__                
\_   _____/___________/  |_  ____ |__|/  |_  ____   \______   \__ __|__|  |    __| _/ |   | ____   _______/  |______  |  | |  |   ___________ 
 |    __)/  _ \_  __ \   __\/    \|  \   __\/ __ \   |    |  _/  |  \  |  |   / __ |  |   |/    \ /  ___/\   __\__  \ |  | |  | _/ __ \_  __ \
 |     \(  <_> )  | \/|  | |   |  \  ||  | \  ___/   |    |   \  |  /  |  |__/ /_/ |  |   |   |  \\___ \  |  |  / __ \|  |_|  |_\  ___/|  | \/
 \___  / \____/|__|   |__| |___|  /__||__|  \___  >  |______  /____/|__|____/\____ |  |___|___|  /____  > |__| (____  /____/____/\___  >__|   
     \/                         \/              \/          \/                    \/           \/     \/            \/               \/        " },
            { "available_builds", "Ecco l'elenco dei build disponibili:" },
            { "enter_choice", "Inserisci il numero del build che vuoi scaricare:" },
            { "invalid_choice", "Scelta non valida. Per favore riprova." },
            { "build_choice", "Hai selezionato :" },
            { "enter_path", "Inserisci il percorso in cui desideri installare questo build:" },
            { "invalid_path", "Percorso non valido. Per favore riprova." },
            { "downloading", "Scaricando su:" },
            { "download_success", "Download completato con successo!" },
            { "download_error", "Errore durante il download o l'estrazione:" },
            { "extracting", "Inizio dell'estrazione..." },
            { "extract_success", "Estrazione completata con successo!" },
            { "press_key", "Premi un tasto per uscire." },
        };
    }
}
