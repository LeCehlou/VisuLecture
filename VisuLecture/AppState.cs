using VisuLecture.Components;

namespace VisuLecture;

public class AppState
{
    private AppConfiguration _config = new AppConfiguration();
    //TODO: ajouter constante
    private string _processingServerURI = "localhost:3000";
    
    public void CheckConnection()
    {
        //TODO: vérifie si le serveur de traitement est bien joignable
    }
    
    public void SendResult()        
    {
        //TODO: envoie la vidéo d'un des élèves et stocke le résultat dans un tableau
    }
    
}