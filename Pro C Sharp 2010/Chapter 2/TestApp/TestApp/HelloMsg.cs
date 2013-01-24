using System;
using System.Windows.Forms;

class HelloMessage
{
    public void Speak(string sB, string sA)
	{
		MessageBox.Show(sA + sB);
	}
}