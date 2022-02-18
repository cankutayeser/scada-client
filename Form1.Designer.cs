namespace scada_client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modbusTCPCom1 = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.digitalPanelMeter1 = new AdvancedHMIControls.DigitalPanelMeter();
            this.digitalPanelMeter2 = new AdvancedHMIControls.DigitalPanelMeter();
            this.meterCompact1 = new AdvancedHMIControls.MeterCompact();
            this.meterCompact2 = new AdvancedHMIControls.MeterCompact();
            this.digitalPanelMeter3 = new AdvancedHMIControls.DigitalPanelMeter();
            this.pilotLight1 = new AdvancedHMIControls.PilotLight();
            this.soundPlayer1 = new AdvancedHMIControls.SoundPlayer();
            this.mushroomButton1 = new AdvancedHMIControls.MushroomButton();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // modbusTCPCom1
            // 
            this.modbusTCPCom1.DisableSubscriptions = false;
            this.modbusTCPCom1.IniFileName = "";
            this.modbusTCPCom1.IniFileSection = null;
            this.modbusTCPCom1.IPAddress = "192.168.0.11";
            this.modbusTCPCom1.MaxReadGroupSize = 20;
            this.modbusTCPCom1.PollRateOverride = 1000;
            this.modbusTCPCom1.SwapBytes = true;
            this.modbusTCPCom1.SwapWords = false;
            this.modbusTCPCom1.TcpipPort = ((ushort)(502));
            this.modbusTCPCom1.TimeOut = 3000;
            this.modbusTCPCom1.UnitId = ((byte)(1));
            // 
            // digitalPanelMeter1
            // 
            this.digitalPanelMeter1.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter1.ComComponent = this.modbusTCPCom1;
            this.digitalPanelMeter1.DecimalPosition = 0;
            this.digitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter1.KeypadMaxValue = 0D;
            this.digitalPanelMeter1.KeypadMinValue = 0D;
            this.digitalPanelMeter1.KeypadScaleFactor = 1D;
            this.digitalPanelMeter1.KeypadText = null;
            this.digitalPanelMeter1.KeypadWidth = 300;
            this.digitalPanelMeter1.Location = new System.Drawing.Point(313, 43);
            this.digitalPanelMeter1.Name = "digitalPanelMeter1";
            this.digitalPanelMeter1.NumberOfDigits = 5;
            this.digitalPanelMeter1.PLCAddressKeypad = "";
            this.digitalPanelMeter1.PLCAddressValue = "40002";
            this.digitalPanelMeter1.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.Size = new System.Drawing.Size(247, 107);
            this.digitalPanelMeter1.TabIndex = 0;
            this.digitalPanelMeter1.Text = "Pressure";
            this.digitalPanelMeter1.Value = 0D;
            this.digitalPanelMeter1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // digitalPanelMeter2
            // 
            this.digitalPanelMeter2.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter2.ComComponent = this.modbusTCPCom1;
            this.digitalPanelMeter2.DecimalPosition = 0;
            this.digitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter2.KeypadMaxValue = 0D;
            this.digitalPanelMeter2.KeypadMinValue = 0D;
            this.digitalPanelMeter2.KeypadScaleFactor = 1D;
            this.digitalPanelMeter2.KeypadText = null;
            this.digitalPanelMeter2.KeypadWidth = 300;
            this.digitalPanelMeter2.Location = new System.Drawing.Point(591, 43);
            this.digitalPanelMeter2.Name = "digitalPanelMeter2";
            this.digitalPanelMeter2.NumberOfDigits = 5;
            this.digitalPanelMeter2.PLCAddressKeypad = "";
            this.digitalPanelMeter2.PLCAddressValue = "40003";
            this.digitalPanelMeter2.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.Size = new System.Drawing.Size(247, 107);
            this.digitalPanelMeter2.TabIndex = 2;
            this.digitalPanelMeter2.Text = "Temperature";
            this.digitalPanelMeter2.Value = 0D;
            this.digitalPanelMeter2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // meterCompact1
            // 
            this.meterCompact1.BackColor = System.Drawing.Color.Transparent;
            this.meterCompact1.Band1Color = System.Drawing.Color.Red;
            this.meterCompact1.Band1EndValue = 100D;
            this.meterCompact1.Band1StartValue = 60D;
            this.meterCompact1.Band2Color = System.Drawing.Color.Yellow;
            this.meterCompact1.Band2EndValue = 60D;
            this.meterCompact1.Band2StartValue = 40D;
            this.meterCompact1.BorderColor = System.Drawing.Color.DimGray;
            this.meterCompact1.BorderWidth = 0;
            this.meterCompact1.ComComponent = this.modbusTCPCom1;
            this.meterCompact1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.meterCompact1.ForeColor = System.Drawing.Color.LightGray;
            this.meterCompact1.HighlightColor = System.Drawing.Color.Red;
            this.meterCompact1.Location = new System.Drawing.Point(591, 219);
            this.meterCompact1.MajorTickColor = System.Drawing.Color.DimGray;
            this.meterCompact1.MajorTickDivisions = 10;
            this.meterCompact1.MajorTickLength = 15;
            this.meterCompact1.Maximum = 100D;
            this.meterCompact1.Minimum = 0D;
            this.meterCompact1.MinorTickColor = System.Drawing.Color.DimGray;
            this.meterCompact1.MinorTickDivisions = 5;
            this.meterCompact1.Name = "meterCompact1";
            this.meterCompact1.NeedleColor = System.Drawing.Color.Maroon;
            this.meterCompact1.NumericFormat = null;
            this.meterCompact1.PLCAddressText = "";
            this.meterCompact1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("meterCompact1.PLCAddressValue")));
            this.meterCompact1.PLCAddressVisible = "";
            this.meterCompact1.ShowLabels = true;
            this.meterCompact1.Size = new System.Drawing.Size(247, 162);
            this.meterCompact1.TabIndex = 4;
            this.meterCompact1.Text = "Temperature";
            this.meterCompact1.Value = 0D;
            // 
            // meterCompact2
            // 
            this.meterCompact2.BackColor = System.Drawing.Color.Transparent;
            this.meterCompact2.Band1Color = System.Drawing.Color.Red;
            this.meterCompact2.Band1EndValue = 1200D;
            this.meterCompact2.Band1StartValue = 1080D;
            this.meterCompact2.Band2Color = System.Drawing.Color.Yellow;
            this.meterCompact2.Band2EndValue = 1080D;
            this.meterCompact2.Band2StartValue = 1040D;
            this.meterCompact2.BorderColor = System.Drawing.Color.DimGray;
            this.meterCompact2.BorderWidth = 0;
            this.meterCompact2.ComComponent = this.modbusTCPCom1;
            this.meterCompact2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.meterCompact2.ForeColor = System.Drawing.Color.LightGray;
            this.meterCompact2.HighlightColor = System.Drawing.Color.Red;
            this.meterCompact2.Location = new System.Drawing.Point(313, 219);
            this.meterCompact2.MajorTickColor = System.Drawing.Color.DimGray;
            this.meterCompact2.MajorTickDivisions = 10;
            this.meterCompact2.MajorTickLength = 15;
            this.meterCompact2.Maximum = 1200D;
            this.meterCompact2.Minimum = 700D;
            this.meterCompact2.MinorTickColor = System.Drawing.Color.DimGray;
            this.meterCompact2.MinorTickDivisions = 5;
            this.meterCompact2.Name = "meterCompact2";
            this.meterCompact2.NeedleColor = System.Drawing.Color.Maroon;
            this.meterCompact2.NumericFormat = null;
            this.meterCompact2.PLCAddressText = "";
            this.meterCompact2.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("meterCompact2.PLCAddressValue")));
            this.meterCompact2.PLCAddressVisible = "";
            this.meterCompact2.ShowLabels = true;
            this.meterCompact2.Size = new System.Drawing.Size(247, 162);
            this.meterCompact2.TabIndex = 5;
            this.meterCompact2.Text = "Pressure";
            this.meterCompact2.Value = 0D;
            // 
            // digitalPanelMeter3
            // 
            this.digitalPanelMeter3.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter3.ComComponent = this.modbusTCPCom1;
            this.digitalPanelMeter3.DecimalPosition = 0;
            this.digitalPanelMeter3.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter3.KeypadMaxValue = 0D;
            this.digitalPanelMeter3.KeypadMinValue = 0D;
            this.digitalPanelMeter3.KeypadScaleFactor = 1D;
            this.digitalPanelMeter3.KeypadText = null;
            this.digitalPanelMeter3.KeypadWidth = 300;
            this.digitalPanelMeter3.Location = new System.Drawing.Point(29, 43);
            this.digitalPanelMeter3.Name = "digitalPanelMeter3";
            this.digitalPanelMeter3.NumberOfDigits = 5;
            this.digitalPanelMeter3.PLCAddressKeypad = "";
            this.digitalPanelMeter3.PLCAddressValue = "40001";
            this.digitalPanelMeter3.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digitalPanelMeter3.Size = new System.Drawing.Size(247, 107);
            this.digitalPanelMeter3.TabIndex = 6;
            this.digitalPanelMeter3.Text = "Hearthbit";
            this.digitalPanelMeter3.Value = 0D;
            this.digitalPanelMeter3.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter3.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pilotLight1
            // 
            this.pilotLight1.Blink = false;
            this.pilotLight1.ComComponent = this.modbusTCPCom1;
            this.pilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1.Location = new System.Drawing.Point(29, 244);
            this.pilotLight1.Name = "pilotLight1";
            this.pilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1.PLCAddressClick = "";
            this.pilotLight1.PLCAddressText = "";
            this.pilotLight1.PLCAddressValue = "00001";
            this.pilotLight1.PLCAddressVisible = "";
            this.pilotLight1.Size = new System.Drawing.Size(94, 137);
            this.pilotLight1.TabIndex = 8;
            this.pilotLight1.Text = "Motion";
            this.pilotLight1.Value = false;
            this.pilotLight1.ValueToWrite = 0;
            // 
            // soundPlayer1
            // 
            this.soundPlayer1.ComComponent = this.modbusTCPCom1;
            this.soundPlayer1.Enabled = true;
            this.soundPlayer1.FileFolder = "C:\\Users\\z004cpxk\\Downloads";
            this.soundPlayer1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("soundPlayer1.PLCAddressValue")));
            this.soundPlayer1.SoundFileName = "alarm.wav";
            this.soundPlayer1.TriggerType = AdvancedHMIControls.SoundPlayer.TriggerTypeOptions.PositiveChange;
            this.soundPlayer1.Value = null;
            // 
            // mushroomButton1
            // 
            this.mushroomButton1.ComComponent = this.modbusTCPCom1;
            this.mushroomButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.MushroomButton.LegendPlates.Large;
            this.mushroomButton1.Location = new System.Drawing.Point(182, 244);
            this.mushroomButton1.MaximumHoldTime = 3000;
            this.mushroomButton1.MinimumHoldTime = 500;
            this.mushroomButton1.Name = "mushroomButton1";
            this.mushroomButton1.OutputType = MfgControl.AdvancedHMI.Controls.MushroomButton.OutputTypes.Toggle;
            this.mushroomButton1.PLCAddressClick = "00002";
            this.mushroomButton1.PLCAddressVisible = "";
            this.mushroomButton1.Size = new System.Drawing.Size(94, 137);
            this.mushroomButton1.TabIndex = 9;
            this.mushroomButton1.Text = "Relay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.mushroomButton1);
            this.Controls.Add(this.pilotLight1);
            this.Controls.Add(this.digitalPanelMeter3);
            this.Controls.Add(this.meterCompact2);
            this.Controls.Add(this.meterCompact1);
            this.Controls.Add(this.digitalPanelMeter2);
            this.Controls.Add(this.digitalPanelMeter1);
            this.Name = "Form1";
            this.Text = "Scada Client / Can Kutay ESER";
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedHMIDrivers.ModbusTCPCom modbusTCPCom1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter2;
        private AdvancedHMIControls.MeterCompact meterCompact1;
        private AdvancedHMIControls.MeterCompact meterCompact2;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter3;
        private AdvancedHMIControls.PilotLight pilotLight1;
        private AdvancedHMIControls.SoundPlayer soundPlayer1;
        private AdvancedHMIControls.MushroomButton mushroomButton1;
    }
}

