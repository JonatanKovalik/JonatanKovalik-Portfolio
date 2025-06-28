import java.util.Random;
import java.util.ArrayList;

// this code was typed by Jonatan Kovalik on 31/12/2024
public class Main {
    public static final String Color_Green_Text = "\u001B[32m";
    public static final String Color_Black_Text = "\u001B[30m";
    public static final String Reset_Color = "\u001B[0m"; // Return to default color

    public static void main(String[] args) {
        Random random = new Random();
        System.out.println("Hello, World!");
        byte boxItems = 30;
        String nameBox = "Books";
        int randomNumber = random.nextInt(121);
        System.out.println("Hello, my name is: " + nameBox + " and I have: " + boxItems + " Books!");
        if (randomNumber <= 100) {
            System.out.println("You young :)");
        } else {
            System.out.println("You old :(");
        }
        System.out.println(randomNumber);

        // List!!!!
        ArrayList<String> nameitem = new ArrayList<>();
        nameitem.add("Books");
        nameitem.add("Notebooks");
        nameitem.add("Pencils");
        nameitem.add("Scissors");
        nameitem.add("Photos");
        nameitem.add("Toys");
        nameitem.add("Gloves");
        nameitem.add("Headphones");
        nameitem.add("Charger");
        nameitem.add("USB Drive");
        nameitem.add("Letters");
        nameitem.add("Stamps");
        nameitem.add("Keys");
        nameitem.add("Wallet");
        nameitem.add("Watch");
        nameitem.add("Sunglasses");
        nameitem.add("Hand Cream");
        nameitem.add("Markers");
        nameitem.add("Phone Case");
        nameitem.add("Tissues");
        nameitem.add("Medicine");
        nameitem.add("Band-aids");
        nameitem.add("Hair Ties");
        nameitem.add("Socks");
        nameitem.add("Baseball Cap");
        nameitem.add("Camera");
        nameitem.add("Batteries");
        nameitem.add("Playing Cards");
        nameitem.add("Umbrella");
        nameitem.add("Water Bottle");
        for (int i = 0; i < nameitem.size(); i++) { // Iterate over the list
            System.out.println(Color_Green_Text + "Name Item: " + nameitem.get(i));
            try {
                Thread.sleep(1000); // Pause for 1 second
            } catch (InterruptedException e) {
                System.err.println("An error occurred: " + e.getMessage());
                e.printStackTrace();
            }
        }

    }
}
