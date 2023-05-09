import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
public class BattleExample extends JFrame implements ActionListener {
    
    Boton buttons[];
    JPanel botones;
    JCheckBox rbtn;
    Boolean status[];
    public BattleExample(){
        status = new Boolean[1];
        status[0] = false;
        botones = new JPanel();
        botones.setSize(300,200);
        botones.setLayout(new GridLayout(10,2));
        buttons = new Boton[20];
        for (int i=0; i<20; i++) {
            buttons[i] = new Boton(status);
            botones.add(buttons[i]);
        }
        rbtn = new JCheckBox("XXXX");
        rbtn.addActionListener(this);
        this.setLayout(new BorderLayout());
        this.add(rbtn, BorderLayout.SOUTH);
        this.add(botones, BorderLayout.CENTER);
        this.setSize(400,300);
        this.setVisible(true);
    }

    public void actionPerformed(ActionEvent actionEvent) {
        AbstractButton abstractButton = (AbstractButton) actionEvent.getSource();
        boolean selected = abstractButton.getModel().isSelected();
        if (selected) {
            this.status[0] = true;
        }else{
            this.status[0] = false;
        }
    }

    public static void main(String args[]) {
        BattleExample example = new BattleExample();
    }
}
