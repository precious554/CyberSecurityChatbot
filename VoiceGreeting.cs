using System.Media;

public class VoiceGreeting
{
    public static void PlayVoice()
    {
        SoundPlayer player = new SoundPlayer("Greeting.wav");
        player.PlaySync();
    }
}