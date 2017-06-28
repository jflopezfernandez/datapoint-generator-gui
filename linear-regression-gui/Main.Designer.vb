<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.gbBulkGenerator = New System.Windows.Forms.GroupBox()
        Me.lblBulkGenerate = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnBulkGenerate = New System.Windows.Forms.Button()
        Me.gbBulkOptions = New System.Windows.Forms.GroupBox()
        Me.cbCommaDelimiters = New System.Windows.Forms.CheckBox()
        Me.btnAddDatapoint = New System.Windows.Forms.Button()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.lblOutputFileName = New System.Windows.Forms.Label()
        Me.sfdSaveDataset = New System.Windows.Forms.SaveFileDialog()
        Me.txtOutputFileName = New System.Windows.Forms.TextBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cbPromptToSaveOnExit = New System.Windows.Forms.CheckBox()
        Me.gbBulkGenerator.SuspendLayout()
        Me.gbBulkOptions.SuspendLayout()
        Me.gbSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(12, 9)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(12, 35)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 13)
        Me.lblY.TabIndex = 1
        Me.lblY.Text = "Y"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "0.00"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "0.00"
        '
        'gbBulkGenerator
        '
        Me.gbBulkGenerator.Controls.Add(Me.gbBulkOptions)
        Me.gbBulkGenerator.Controls.Add(Me.btnBulkGenerate)
        Me.gbBulkGenerator.Controls.Add(Me.TextBox3)
        Me.gbBulkGenerator.Controls.Add(Me.lblBulkGenerate)
        Me.gbBulkGenerator.Location = New System.Drawing.Point(163, 6)
        Me.gbBulkGenerator.Name = "gbBulkGenerator"
        Me.gbBulkGenerator.Size = New System.Drawing.Size(228, 371)
        Me.gbBulkGenerator.TabIndex = 4
        Me.gbBulkGenerator.TabStop = False
        Me.gbBulkGenerator.Text = "Bulk Generator"
        '
        'lblBulkGenerate
        '
        Me.lblBulkGenerate.AutoSize = True
        Me.lblBulkGenerate.Location = New System.Drawing.Point(6, 16)
        Me.lblBulkGenerate.Name = "lblBulkGenerate"
        Me.lblBulkGenerate.Size = New System.Drawing.Size(155, 13)
        Me.lblBulkGenerate.TabIndex = 0
        Me.lblBulkGenerate.Text = "Generate N random data points"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = "0"
        '
        'btnBulkGenerate
        '
        Me.btnBulkGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBulkGenerate.Location = New System.Drawing.Point(9, 339)
        Me.btnBulkGenerate.Name = "btnBulkGenerate"
        Me.btnBulkGenerate.Size = New System.Drawing.Size(213, 26)
        Me.btnBulkGenerate.TabIndex = 2
        Me.btnBulkGenerate.Text = "Bulk Generate"
        Me.btnBulkGenerate.UseVisualStyleBackColor = True
        '
        'gbBulkOptions
        '
        Me.gbBulkOptions.Controls.Add(Me.cbCommaDelimiters)
        Me.gbBulkOptions.Location = New System.Drawing.Point(9, 233)
        Me.gbBulkOptions.Name = "gbBulkOptions"
        Me.gbBulkOptions.Size = New System.Drawing.Size(213, 100)
        Me.gbBulkOptions.TabIndex = 3
        Me.gbBulkOptions.TabStop = False
        Me.gbBulkOptions.Text = "Bulk Generation Options"
        '
        'cbCommaDelimiters
        '
        Me.cbCommaDelimiters.AutoSize = True
        Me.cbCommaDelimiters.Location = New System.Drawing.Point(21, 19)
        Me.cbCommaDelimiters.Name = "cbCommaDelimiters"
        Me.cbCommaDelimiters.Size = New System.Drawing.Size(131, 17)
        Me.cbCommaDelimiters.TabIndex = 0
        Me.cbCommaDelimiters.Text = "Use Comma Delimiters"
        Me.cbCommaDelimiters.UseVisualStyleBackColor = True
        '
        'btnAddDatapoint
        '
        Me.btnAddDatapoint.Location = New System.Drawing.Point(12, 58)
        Me.btnAddDatapoint.Name = "btnAddDatapoint"
        Me.btnAddDatapoint.Size = New System.Drawing.Size(145, 23)
        Me.btnAddDatapoint.TabIndex = 5
        Me.btnAddDatapoint.Text = "Add Datapoint"
        Me.btnAddDatapoint.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.cbPromptToSaveOnExit)
        Me.gbSettings.Controls.Add(Me.btnSet)
        Me.gbSettings.Controls.Add(Me.txtOutputFileName)
        Me.gbSettings.Controls.Add(Me.lblOutputFileName)
        Me.gbSettings.Location = New System.Drawing.Point(12, 87)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(145, 252)
        Me.gbSettings.TabIndex = 6
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings"
        '
        'lblOutputFileName
        '
        Me.lblOutputFileName.AutoSize = True
        Me.lblOutputFileName.Location = New System.Drawing.Point(6, 16)
        Me.lblOutputFileName.Name = "lblOutputFileName"
        Me.lblOutputFileName.Size = New System.Drawing.Size(92, 13)
        Me.lblOutputFileName.TabIndex = 0
        Me.lblOutputFileName.Text = "Output File Name:"
        '
        'txtOutputFileName
        '
        Me.txtOutputFileName.Location = New System.Drawing.Point(6, 32)
        Me.txtOutputFileName.Name = "txtOutputFileName"
        Me.txtOutputFileName.Size = New System.Drawing.Size(83, 20)
        Me.txtOutputFileName.TabIndex = 1
        Me.txtOutputFileName.Text = "default.dat"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(95, 31)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(44, 20)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(12, 345)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(145, 32)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cbPromptToSaveOnExit
        '
        Me.cbPromptToSaveOnExit.AutoSize = True
        Me.cbPromptToSaveOnExit.Location = New System.Drawing.Point(6, 229)
        Me.cbPromptToSaveOnExit.Name = "cbPromptToSaveOnExit"
        Me.cbPromptToSaveOnExit.Size = New System.Drawing.Size(134, 17)
        Me.cbPromptToSaveOnExit.TabIndex = 3
        Me.cbPromptToSaveOnExit.Text = "Prompt to Save on Exit"
        Me.cbPromptToSaveOnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 389)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.btnAddDatapoint)
        Me.Controls.Add(Me.gbBulkGenerator)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regression Datapoint Generator"
        Me.gbBulkGenerator.ResumeLayout(False)
        Me.gbBulkGenerator.PerformLayout()
        Me.gbBulkOptions.ResumeLayout(False)
        Me.gbBulkOptions.PerformLayout()
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents gbBulkGenerator As GroupBox
    Friend WithEvents gbBulkOptions As GroupBox
    Friend WithEvents cbCommaDelimiters As CheckBox
    Friend WithEvents btnBulkGenerate As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblBulkGenerate As Label
    Friend WithEvents btnAddDatapoint As Button
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents btnSet As Button
    Friend WithEvents txtOutputFileName As TextBox
    Friend WithEvents lblOutputFileName As Label
    Friend WithEvents sfdSaveDataset As SaveFileDialog
    Friend WithEvents cmdExit As Button
    Friend WithEvents cbPromptToSaveOnExit As CheckBox
End Class
