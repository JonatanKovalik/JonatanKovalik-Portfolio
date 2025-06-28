import javax.swing.*;
import java.awt.*;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        JFrame framegame = new JFrame("Monkey Simulator");
        framegame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        framegame.setSize(1920, 1080);
        ImageIcon monkeyimage = new ImageIcon("Image/MonkeysImage.jpg");
        JLabel label = new JLabel(monkeyimage);
        framegame.getContentPane().add(label, BorderLayout.CENTER);
        JLabel textLabel = new JLabel("See the text on the output!", JLabel.CENTER);
        textLabel.setForeground(Color.RED);
        framegame.getContentPane().add(textLabel, BorderLayout.NORTH);
        framegame.setResizable(false);
        framegame.setVisible(true);
        textLabel.setForeground(Color.black);
        Font largeFont = new Font("Arial", Font.BOLD, 50);
        textLabel.setFont(largeFont);
        textLabel.setOpaque(false);
        textLabel.setBounds(600, 500, 700, 100);
        //------------------------------------------------
        Random random = new Random();
        int Number_Actions = 0;
        Monkey monkey_animal = new Monkey(); //Model
        while(true) {
            Number_Actions = random.nextInt(1, 4); // 1-3!!
            if (Number_Actions == 1){
                monkey_animal.eat();
            } else if (Number_Actions == 2) {
                monkey_animal.sleep();
            } else if (Number_Actions == 3) {
                monkey_animal.Voice();
            }
            try {
                Thread.sleep(random.nextInt(4, 11) * 1000); // 11 sec wait
            } catch (InterruptedException e) {
                System.err.println("An error occurred: " + e.getMessage());
                e.printStackTrace();
            }
        }
    }
}
