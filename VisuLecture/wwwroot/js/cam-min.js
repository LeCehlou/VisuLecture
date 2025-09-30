export async function ensureStream(videoElementId, facing = "user") {
    const video = document.getElementById(videoElementId);
    if (!video) throw new Error("Élément <video> introuvable.");

    const stream = await navigator.mediaDevices.getUserMedia({
        video: { facingMode: facing},
        audio: true
    });

    //TODO: remove le flux
    video.srcObject = stream;
    await video.play();

    // Récupère l’ID du device vidéo choisi par le navigateur
    const track = stream.getVideoTracks()[0];
    const settings = track.getSettings ? track.getSettings() : {};
    const deviceId = settings.deviceId || track.getCapabilities?.().deviceId || null;

    // `track.label` est rempli après permission accordée
    const label = track.label || "Caméra";

    return { deviceId, label };
}
