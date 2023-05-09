package ejercicios1p.ejercicio1;
import java.awt.event.*;
import java.awt.*;

public class Ventana extends Frame implements ActionListener{
    Button btn;
    Button btn_south;
    Button btn_east;
    Panel p_center;
    Panel p_calc;
    Button btn_plus;
    TextField txt;
    TextArea txt_history;
    int num_oks;
    int sum = 0;
    public Ventana() 
    {
        btn = new Button("OK");
        btn_plus = new Button(" + ");
        btn_plus.addActionListener(this);
        btn_south = new Button("SALIR");
        btn_east = new Button("LIMPIAR");
        txt_history = new TextArea();
        p_center = new Panel();
        p_center.setLayout(new BorderLayout());
        p_calc = new Panel();
        p_calc.setLayout(new BorderLayout());

        num_oks = 0;
        txt = new TextField();

        btn.addActionListener(this);
        btn_south.addActionListener(this);
        btn_east.addActionListener(this);
        this.setLayout(new BorderLayout());
        p_center.add(btn, BorderLayout.CENTER);
        p_center.add(btn_south, BorderLayout.WEST);
        p_center.add(btn_east, BorderLayout.EAST);
        this.add(txt_history, BorderLayout.CENTER);
        this.add(p_center, BorderLayout.SOUTH);
        p_calc.add(txt, BorderLayout.CENTER);
        p_calc.add(btn_plus, BorderLayout.EAST);
        this.add(p_calc, BorderLayout.NORTH);
        this.setSize(300,400);
        this.setVisible(true);
    }
    public void actionPerformed(ActionEvent e) {
        if(e.getSource()==btn) {
            num_oks++;
            btn.setLabel(num_oks + " Ok");
            txt.setText("=" + sum);
        }
        if (e.getActionCommand().equals("LIMPIAR")) {
            num_oks = 0;
            btn.setLabel("OK");
            txt.setText("");
        }
        // if (e.getSource()==btn_south) {
        // System.out.println(e.getActionCommand());
        if (e.getActionCommand().equals("SALIR")) {
            System.exit(0);
        }
        if (e.getSource()==btn_plus) {
            if (!txt.getText().equals("")) {
                try{
                    int num = Integer.parseInt(txt.getText());
                    txt_history.append(txt.getText() + "\n");
                    txt.setText("");
                    sum+=num;
                }catch(NumberFormatException ex) {
                    txt.setText("");
                }
            }
        }
        // }
        
    }
    public static void main(String args[]) {
        new Ventana();
    }
}
