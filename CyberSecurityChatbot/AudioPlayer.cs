
 
using System.Media;

namespace CybersecurityAwarenessChatbot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("CyberAudio.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio file not found.");
            }
        }
    }
}