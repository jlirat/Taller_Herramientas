package ejercicios2p;

import java.util.Random;

public class MainSinHilo implements Runnable {
    String name;

    public MainSinHilo(String n) {
        this.name = n;
    }
    @Override
    public void run() {
        for(int i = 0; i<10;i++)
            print();
    }
    public void print() {
        Random r = new Random();
        int d = r.nextInt(1000);
        System.out.println(String.format("%s: Número generado: %d",name, d));
    }

    public static void main(String args[]) {
        MainSinHilo m1 = new MainSinHilo("P1");
        MainSinHilo m2 = new MainSinHilo("P2");
        MainSinHilo m3 = new MainSinHilo("P3");
        Thread t1 = new Thread(m1);
        Thread t2 = new Thread(m2);
        Thread t3 = new Thread(m3);
        t1.setPriority(Thread.MAX_PRIORITY);
        t2.setPriority(Thread.NORM_PRIORITY);
        t3.setPriority(Thread.MIN_PRIORITY);
        t1.start();
        t2.start();
        t3.start();
        // m1.run();
        // m2.run();
        // m3.run();
        
    }
}
