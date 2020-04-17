Namespace RichEditNavigation
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.btnBackward = New System.Windows.Forms.Button()
			Me.btnForward = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(12, 58)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(1084, 404)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.richEditControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richEditControl1_KeyDown);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.richEditControl1.HyperlinkClick += new DevExpress.XtraRichEdit.HyperlinkClickEventHandler(this.richEditControl1_HyperlinkClick);
			' 
			' btnBackward
			' 
			Me.btnBackward.Enabled = False
			Me.btnBackward.Location = New System.Drawing.Point(12, 12)
			Me.btnBackward.Name = "btnBackward"
			Me.btnBackward.Size = New System.Drawing.Size(40, 40)
			Me.btnBackward.TabIndex = 1
			Me.btnBackward.Text = "<"
			Me.btnBackward.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
			' 
			' btnForward
			' 
			Me.btnForward.Enabled = False
			Me.btnForward.Location = New System.Drawing.Point(58, 12)
			Me.btnForward.Name = "btnForward"
			Me.btnForward.Size = New System.Drawing.Size(40, 40)
			Me.btnForward.TabIndex = 2
			Me.btnForward.Text = ">"
			Me.btnForward.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1108, 474)
			Me.Controls.Add(Me.btnForward)
			Me.Controls.Add(Me.btnBackward)
			Me.Controls.Add(Me.richEditControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents btnBackward As System.Windows.Forms.Button
		Private WithEvents btnForward As System.Windows.Forms.Button
	End Class
End Namespace

