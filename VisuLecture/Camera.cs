namespace VisuLecture.Components;

public class Camera
{
    private int _fps;
    private int _width;
    private int _height;
    private int _bitrate;
    private Byte[] _videoContent;
    
    public void Calibrate()
    {
        //TODO: méthode qui doit gérer toute la logique de calibration (5 ou 9 points)
        //9 points nous permettrait d'être plus précis
        //5 points suffiraient pour les envoyer à EyeWare
        return;
    }

    public void SendStillImage(int length)
    {
        //TODO: On transforme le flux vidéo en une seule image continue pendant length (en secondes)
        return;
    }

    public void StartRecording()
    {
        //TODO: Lance l'enregistrement
        return;
    }

    public void StopRecording()
    {
        //TODO: Arrête l'enregistrement, et stocke le contenu dans un blob/fichier
    }
    
    public void TakeScreenshot()
    {
        //TODO: Prends un screenshot et renvoie la valeur
        return;
    }
}