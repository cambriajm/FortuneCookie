
using System.IO.Ports;
namespace SerialExample;

public partial class SerialForm : Form
{
    public SerialForm()
    {
        InitializeComponent();
        UpdatePortSelection();
    }

    SerialPort _serialPort = new SerialPort();
    void SerialPortSetup()
    {
        _serialPort.Close();
        _serialPort.PortName = PortsComboBox.SelectedItem.ToString();
        _serialPort.BaudRate = 9600;
        _serialPort.DataBits = 8;
        _serialPort.Parity = Parity.None;
        //_serialPort.StopBits = StopBits.None;


    }

    void SerialConnect()
    {
        _serialPort.Close();
        _serialPort.Open();
    }

    void SerialSend()
    {
        _serialPort.Write("hello");
        _serialPort.Write("1111");
    }

    void SerialRead()
    {
        //SerialTextBox.Text = _serialPort.ReadExisting();
        byte[] input = new byte[_serialPort.BytesToRead];
        int byteNumber = 0;
        _serialPort.Read(input,0,input.Length);

        foreach (byte b in input)
        {
            byteNumber++;
            ComListBox.Items.Add($"{byteNumber}");
        }
    }

    string[] GetSerialPorts()
    {
        return SerialPort.GetPortNames();
    }

    void UpdatePortSelection()
    {
        foreach (string port in GetSerialPorts())
        {
            PortsComboBox.Items.Add(port);
        }

        if (PortsComboBox.Items.Count > 0)
        {
            PortsComboBox.SelectedIndex = 0;
        }

    }

    void TestQyAtBoard()
    {
        byte[] thingy = { 0xf0 };
        _serialPort.Write(thingy, 0, 1);
    }

    // Event Handlers Below here ******************************************
    private void ExitButton_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void ConnectButton_Click_1(object sender, EventArgs e)
    {
        SerialPortSetup();
        SerialConnect();
    }

    private void SendButton_Click_1(object sender, EventArgs e)
    {
        // SerialSend();
        TestQyAtBoard();
    }

    private void ReadButton_Click_1(object sender, EventArgs e)
    {
        SerialRead();
    }

    private void StatusTimer_Tick(object sender, EventArgs e)
    {
        string portName;
        int rxBuffer, txBuffer;
        if (_serialPort.IsOpen)
        {
            portName = _serialPort.PortName;
            rxBuffer = _serialPort.BytesToRead;
            txBuffer = _serialPort.BytesToWrite;
        }
        else
        {
            portName = "none";
            rxBuffer = 0;
            txBuffer = 0;
        }

        StatusLabel.Text = $"Port: {portName} tx:{txBuffer} rx:{rxBuffer}";
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        SendButton = new Button();
        ConnectButton = new Button();
        ReadButton = new Button();
        ExitButton = new Button();
        statusStrip1 = new StatusStrip();
        StatusLabel = new ToolStripStatusLabel();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        SerialTextBox = new TextBox();
        PortsComboBox = new ComboBox();
        StatusTimer = new System.Windows.Forms.Timer(components);
        ComListBox = new ListBox();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // SendButton
        // 
        SendButton.Location = new Point(239, 347);
        SendButton.Name = "SendButton";
        SendButton.Size = new Size(108, 49);
        SendButton.TabIndex = 0;
        SendButton.Text = "Send";
        SendButton.UseVisualStyleBackColor = true;
        SendButton.Click += SendButton_Click_1;
        // 
        // ConnectButton
        // 
        ConnectButton.Location = new Point(353, 347);
        ConnectButton.Name = "ConnectButton";
        ConnectButton.Size = new Size(108, 49);
        ConnectButton.TabIndex = 1;
        ConnectButton.Text = "Connect";
        ConnectButton.UseVisualStyleBackColor = true;
        ConnectButton.Click += ConnectButton_Click_1;
        // 
        // ReadButton
        // 
        ReadButton.Location = new Point(467, 347);
        ReadButton.Name = "ReadButton";
        ReadButton.Size = new Size(108, 49);
        ReadButton.TabIndex = 2;
        ReadButton.Text = "Read";
        ReadButton.UseVisualStyleBackColor = true;
        ReadButton.Click += ReadButton_Click_1;
        // 
        // ExitButton
        // 
        ExitButton.Location = new Point(581, 347);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(108, 49);
        ExitButton.TabIndex = 3;
        ExitButton.Text = "Exit";
        ExitButton.UseVisualStyleBackColor = true;
        ExitButton.Click += ExitButton_Click_1;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel, toolStripStatusLabel1 });
        statusStrip1.Location = new Point(0, 399);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(755, 26);
        statusStrip1.TabIndex = 4;
        statusStrip1.Text = "statusStrip1";
        // 
        // StatusLabel
        // 
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(0, 20);
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(151, 20);
        toolStripStatusLabel1.Text = "toolStripStatusLabel1";
        // 
        // SerialTextBox
        // 
        SerialTextBox.Location = new Point(31, 75);
        SerialTextBox.Name = "SerialTextBox";
        SerialTextBox.Size = new Size(156, 27);
        SerialTextBox.TabIndex = 5;
        // 
        // PortsComboBox
        // 
        PortsComboBox.FormattingEnabled = true;
        PortsComboBox.Location = new Point(31, 108);
        PortsComboBox.Name = "PortsComboBox";
        PortsComboBox.Size = new Size(156, 28);
        PortsComboBox.TabIndex = 6;
        // 
        // StatusTimer
        // 
        StatusTimer.Enabled = true;
        StatusTimer.Interval = 250;
        StatusTimer.Tick += StatusTimer_Tick;
        // 
        // ComListBox
        // 
        ComListBox.FormattingEnabled = true;
        ComListBox.Location = new Point(257, 76);
        ComListBox.Name = "ComListBox";
        ComListBox.Size = new Size(395, 244);
        ComListBox.TabIndex = 7;
        // 
        // SerialForm
        // 
        ClientSize = new Size(755, 425);
        Controls.Add(ComListBox);
        Controls.Add(PortsComboBox);
        Controls.Add(SerialTextBox);
        Controls.Add(statusStrip1);
        Controls.Add(ExitButton);
        Controls.Add(ReadButton);
        Controls.Add(ConnectButton);
        Controls.Add(SendButton);
        Name = "SerialForm";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    private Button SendButton;
    private Button ConnectButton;
    private Button ReadButton;
    private Button ExitButton;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel StatusLabel;
    private TextBox SerialTextBox;
    private ComboBox PortsComboBox;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.Timer StatusTimer;
    private System.ComponentModel.IContainer components;

    private void timer1_Tick(object sender, EventArgs e)
    {

    }

    private ListBox ComListBox;
}