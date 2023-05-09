import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
public class Boton extends JButton implements ActionListener {
    private Boolean []status;
    private static boolean defaultColor = true;
    public Boton(Boolean []s) {
        status = s;
        this.setBounds(0,0, 40, 40);
        addActionListener(this);
        System.out.println("Boton n");
    }

    public void actionPerformed(ActionEvent e) {
        System.out.println("Valor de status:" + status[0]);
        if (status[0]) {
            this.setBackground(Color.RED);
        } else {
            this.setBackground(Color.BLUE);
        }
    }
}
