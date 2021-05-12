using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class frmPrincipal : Form
    {
        Image tortuga = null;
        int x, y;
        int fx, fy;
        int mono = 0;
        double velocidad = .01;
        int tiempo = 200;
        bool tipo = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            mono++;
            if (mono >= 3) mono = 0;
            if (tipo) fy = 250;
            else
                fy = 0;
            Console.WriteLine("Mono:" + mono);
            CollisionCheck();
            areaTrabajo.Invalidate();
            
        }

        private void CollisionCheck()
        {
            // Si llega al límite derecho
            if ((x + 250) >= areaTrabajo.Width)
            {
                x = areaTrabajo.Width - 250;
            }
            if (x <= 0)
            {
                x = 0;
            }
        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            int distancia = (int)(velocidad * tiempo);
            if (e.KeyChar == 65)
            {
                x-=distancia;
                tipo = true;
            }
            if(e.KeyChar == 68)
            {
                x+=distancia;
                tipo = true;
            }
                
            
        }

        private void frmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Liberando");
            tipo = false;
        }

        public frmPrincipal()
        {
            InitializeComponent();
            tortuga = Image.FromFile("Recursos\\tortuga_array.png");
            x = y = 0;
            fx = fy = 0;
            tipo = false;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void areaTrabajo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(tortuga, 
                            new Rectangle(x,y,250,250),
                            fx+mono*250,fy,250,255, GraphicsUnit.Pixel);
        }
    }
}
