import javax.sound.sampled.*;
import java.io.File;
import java.io.IOException;

public class Monkey extends Animal {
    public void Voice() {
        try {
            File soundMonkey01 = new File("SoundSFX/monkey-128368.wav");
            AudioInputStream audioInputStream = AudioSystem.getAudioInputStream(soundMonkey01);
            Clip clip = AudioSystem.getClip();
            clip.open(audioInputStream);
            clip.start();
        } catch (UnsupportedAudioFileException e) {
            System.out.println("The audio file is unsupported: " + e.getMessage());
        } catch (IOException e) {
            System.out.println("Error reading the audio file: " + e.getMessage());
        } catch (LineUnavailableException e) {
            System.out.println("Audio line unavailable: " + e.getMessage());
        }
    }
}
