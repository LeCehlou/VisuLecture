using Microsoft.JSInterop;
using VisuLecture.Components;

namespace VisuLecture;

public class AppState
{
    private AppConfiguration _config = new AppConfiguration();

    public Camera? Camera { get; set; }
    //TODO: ajouter constante
    private string _processingServerURI = "localhost:3000";
    public IJSRuntime JsRuntime { get; }
    private bool _initialized;


    public AppState(IJSRuntime jsRuntime)
    {
        JsRuntime = jsRuntime;
    }

    public void CheckConnection()
    {
        //TODO: vérifie si le serveur de traitement est bien joignable
    }
    
    public void SendResult()        
    {
        //TODO: envoie la vidéo d'un des élèves et stocke le résultat dans un tableau
    }
    
}