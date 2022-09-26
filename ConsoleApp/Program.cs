using System;
using System.Drawing;
using System.Windows.Forms;


// Application.Run(new Form());


Form form = new();


form.Text = "My first app";
form.Size = new Size(800, 600);


// EventHandler (delegate)
// EventArgs    (class)




form.MouseClick += (s, e) =>
{
    Console.WriteLine($"{e.Location}");
    // MessageBox.Show(e.Location.ToString());
};




Button btn1 = new Button
{
    Text = "Btn 1",
    Size = new Size(50, 30),
    Location = new Point(100, 150)
};

Button btn2 = new Button
{
    Text = "Btn 2",
    Size = new Size(50, 30),
    Location = new Point(200, 250)
};


btn1.Click += Btn_Click;
btn2.Click += Btn_Click;


void Btn_Click(object? sender, EventArgs e)
{
    Console.WriteLine((sender as Button)?.Text);
}




form.Controls.Add(btn1);
form.Controls.Add(btn2);



// form.Show();
form.ShowDialog();