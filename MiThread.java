import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;

public class MiThread extends Thread {
    private String message;

    public MiThread(String threadName){
        this.message = "Hola Mundo desde:" + threadName;
    }

    public void run()
    {
        Random r = new Random();
        int timeToSleep = r.nextInt(1000);
        try{
            this.sleep(timeToSleep);
        }catch(InterruptedException ex) {
            ex.printStackTrace();
        }
        System.out.println(message);
    }
    
    public void sleep(int milis) throws InterruptedException {
        Thread.sleep(milis);
    }

    public static void main(String args[]) throws IOException {
        // MiThread t1 = new MiThread("t10");
        // MiThread t2 = new MiThread("t11");
        // MiThread[] t = new MiThread[10];
        // for (int i = 0; i< t.length;i++) {
        //     t[i] = new MiThread("t" + i);
        //     t[i].start();
        // }
        // t1.start();
        // try{
        //     t1.sleep(500);

        // }catch(InterruptedException iex) {
        //     iex.printStackTrace();
        // }
        // t2.start();
        ServerSocket server = new ServerSocket(5000);

        Socket c = server.accept();
        BufferedReader in =  new BufferedReader(new InputStreamReader(c.getInputStream()));
        PrintWriter out = new PrintWriter(c.getOutputStream());
        // Protocolo Comunicación: Primero Servidor - Cliente
        String line = "";
        do{
            line = in.readLine();
            System.out.println(line);
            if (line.equals("bye")) {
                out.println(line);    
            }else {
                out.println("OK desde el servidor:" + line);
            }
            out.flush();
            System.out.println("OK desde el servidor:" + line);
        }while(!line.equals("bye"));
        c.close();
        server.close();
    }
}
