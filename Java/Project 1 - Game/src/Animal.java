import java.util.Random;

public class Animal{
    Random random = new Random();
    int number = random.nextInt(1,4);
    public void eat(){
        if(number == 1) {
            System.out.println("Nam nam nam nam..");
        }
        if(number == 2){
            System.out.println("I am eating, let me be alone");
        }
        if(number == 3) {
            System.out.println("Ok seat near, with me but be quit!");
        }
    }
    public void sleep() {
        System.out.println("give me sleep, go out!");
    }
}
