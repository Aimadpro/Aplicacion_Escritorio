using System;
using System.Drawing;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    // Propiedad para definir el radio del borde redondeado
    public int BorderRadius { get; set; } = 15;
    // Propiedad para definir el tamaño de la sombra
    public int ShadowSize { get; set; } = 5;
    // Propiedad para definir el color de la sombra
    public Color ShadowColor { get; set; } = Color.Gray;

    public RoundedTextBox()
    {
        // Cambiar el estilo del borde para que no dibuje el borde predeterminado
        this.BorderStyle = BorderStyle.None;
    }

    // Sobrescribir el método OnPaint para dibujar el borde redondeado con sombra
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Crear un pincel para la sombra
        using (Brush shadowBrush = new SolidBrush(ShadowColor))
        {
            // Definir el rectángulo de la sombra
            Rectangle shadowRect = new Rectangle(ShadowSize, ShadowSize, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            // Dibujar el borde redondeado con sombra
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(shadowBrush, shadowRect);
        }

        // Crear un pincel para el borde
        using (Pen pen = new Pen(Color.LightBlue, 2))  // Color y grosor del borde
        {
            // Definir el rectángulo para el borde redondeado
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            // Dibujar el borde redondeado
            e.Graphics.DrawArc(pen, 0, 0, BorderRadius * 2, BorderRadius * 2, 180, 90);  // Esquina superior izquierda
            e.Graphics.DrawArc(pen, rect.Width - BorderRadius * 2, 0, BorderRadius * 2, BorderRadius * 2, 270, 90);  // Esquina superior derecha
            e.Graphics.DrawArc(pen, rect.Width - BorderRadius * 2, rect.Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 0, 90);  // Esquina inferior derecha
            e.Graphics.DrawArc(pen, 0, rect.Height - BorderRadius * 2, BorderRadius * 2, BorderRadius * 2, 90, 90);  // Esquina inferior izquierda

            e.Graphics.DrawLine(pen, BorderRadius, 0, rect.Width - BorderRadius, 0);  // Línea superior
            e.Graphics.DrawLine(pen, rect.Width, BorderRadius, rect.Width, rect.Height - BorderRadius);  // Línea derecha
            e.Graphics.DrawLine(pen, BorderRadius, rect.Height, rect.Width - BorderRadius, rect.Height);  // Línea inferior
            e.Graphics.DrawLine(pen, 0, BorderRadius, 0, rect.Height - BorderRadius);  // Línea izquierda
        }
    }

    // Redibuja el borde cuando cambian los tamaños o el texto
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate();  // Esto obliga a que se vuelva a dibujar el control
    }
}
