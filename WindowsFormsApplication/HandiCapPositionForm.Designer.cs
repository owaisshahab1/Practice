namespace WindowsFormsApplication
{
    partial class HandiCapPositionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PawnradioButton = new System.Windows.Forms.RadioButton();
            this.PawnMoveradioButton = new System.Windows.Forms.RadioButton();
            this.Pawn_f7_MoveradioButton = new System.Windows.Forms.RadioButton();
            this.Pawn_f7_2_MovesradioButton = new System.Windows.Forms.RadioButton();
            this.Pawn_f7_3_MovesradioButton = new System.Windows.Forms.RadioButton();
            this.RookKnightradioButton = new System.Windows.Forms.RadioButton();
            this.RookMoveKnightradioButton = new System.Windows.Forms.RadioButton();
            this.KnightradioButton = new System.Windows.Forms.RadioButton();
            this.KnightMoveradioButton = new System.Windows.Forms.RadioButton();
            this.RookradioButton = new System.Windows.Forms.RadioButton();
            this.RookMoveradioButton = new System.Windows.Forms.RadioButton();
            this.Rook_2_KnightradioButton = new System.Windows.Forms.RadioButton();
            this.QueenKnightradioButton = new System.Windows.Forms.RadioButton();
            this.QueenradioButton = new System.Windows.Forms.RadioButton();
            this.QueenMoveradioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PawnradioButton
            // 
            this.PawnradioButton.AutoSize = true;
            this.PawnradioButton.Location = new System.Drawing.Point(36, 12);
            this.PawnradioButton.Name = "PawnradioButton";
            this.PawnradioButton.Size = new System.Drawing.Size(52, 17);
            this.PawnradioButton.TabIndex = 1;
            this.PawnradioButton.TabStop = true;
            this.PawnradioButton.Text = "Pawn";
            this.PawnradioButton.UseVisualStyleBackColor = true;
            this.PawnradioButton.CheckedChanged += new System.EventHandler(this.PawnradioButton_CheckedChanged);
            // 
            // PawnMoveradioButton
            // 
            this.PawnMoveradioButton.AutoSize = true;
            this.PawnMoveradioButton.Location = new System.Drawing.Point(36, 35);
            this.PawnMoveradioButton.Name = "PawnMoveradioButton";
            this.PawnMoveradioButton.Size = new System.Drawing.Size(91, 17);
            this.PawnMoveradioButton.TabIndex = 1;
            this.PawnMoveradioButton.TabStop = true;
            this.PawnMoveradioButton.Text = "Pawn + Move";
            this.PawnMoveradioButton.UseVisualStyleBackColor = true;
            this.PawnMoveradioButton.CheckedChanged += new System.EventHandler(this.PawnMoveradioButton_CheckedChanged);
            // 
            // Pawn_f7_MoveradioButton
            // 
            this.Pawn_f7_MoveradioButton.AutoSize = true;
            this.Pawn_f7_MoveradioButton.Location = new System.Drawing.Point(36, 58);
            this.Pawn_f7_MoveradioButton.Name = "Pawn_f7_MoveradioButton";
            this.Pawn_f7_MoveradioButton.Size = new System.Drawing.Size(109, 17);
            this.Pawn_f7_MoveradioButton.TabIndex = 1;
            this.Pawn_f7_MoveradioButton.TabStop = true;
            this.Pawn_f7_MoveradioButton.Text = "Pawn (f7) + Move";
            this.Pawn_f7_MoveradioButton.UseVisualStyleBackColor = true;
            this.Pawn_f7_MoveradioButton.CheckedChanged += new System.EventHandler(this.Pawn_f7_MoveradioButton_CheckedChanged);
            // 
            // Pawn_f7_2_MovesradioButton
            // 
            this.Pawn_f7_2_MovesradioButton.AutoSize = true;
            this.Pawn_f7_2_MovesradioButton.Location = new System.Drawing.Point(36, 81);
            this.Pawn_f7_2_MovesradioButton.Name = "Pawn_f7_2_MovesradioButton";
            this.Pawn_f7_2_MovesradioButton.Size = new System.Drawing.Size(123, 17);
            this.Pawn_f7_2_MovesradioButton.TabIndex = 1;
            this.Pawn_f7_2_MovesradioButton.TabStop = true;
            this.Pawn_f7_2_MovesradioButton.Text = "Pawn (f7) + 2 Moves";
            this.Pawn_f7_2_MovesradioButton.UseVisualStyleBackColor = true;
            this.Pawn_f7_2_MovesradioButton.CheckedChanged += new System.EventHandler(this.Pawn_f7_2_MovesradioButton_CheckedChanged);
            // 
            // Pawn_f7_3_MovesradioButton
            // 
            this.Pawn_f7_3_MovesradioButton.AutoSize = true;
            this.Pawn_f7_3_MovesradioButton.Location = new System.Drawing.Point(36, 104);
            this.Pawn_f7_3_MovesradioButton.Name = "Pawn_f7_3_MovesradioButton";
            this.Pawn_f7_3_MovesradioButton.Size = new System.Drawing.Size(123, 17);
            this.Pawn_f7_3_MovesradioButton.TabIndex = 1;
            this.Pawn_f7_3_MovesradioButton.TabStop = true;
            this.Pawn_f7_3_MovesradioButton.Text = "Pawn (f7) + 3 Moves";
            this.Pawn_f7_3_MovesradioButton.UseVisualStyleBackColor = true;
            this.Pawn_f7_3_MovesradioButton.CheckedChanged += new System.EventHandler(this.Pawn_f7_3_MovesradioButton_CheckedChanged);
            // 
            // RookKnightradioButton
            // 
            this.RookKnightradioButton.AutoSize = true;
            this.RookKnightradioButton.Location = new System.Drawing.Point(36, 127);
            this.RookKnightradioButton.Name = "RookKnightradioButton";
            this.RookKnightradioButton.Size = new System.Drawing.Size(95, 17);
            this.RookKnightradioButton.TabIndex = 1;
            this.RookKnightradioButton.TabStop = true;
            this.RookKnightradioButton.Text = "Rook % Knight";
            this.RookKnightradioButton.UseVisualStyleBackColor = true;
            this.RookKnightradioButton.CheckedChanged += new System.EventHandler(this.RookKnightradioButton_CheckedChanged);
            // 
            // RookMoveKnightradioButton
            // 
            this.RookMoveKnightradioButton.AutoSize = true;
            this.RookMoveKnightradioButton.Location = new System.Drawing.Point(36, 150);
            this.RookMoveKnightradioButton.Name = "RookMoveKnightradioButton";
            this.RookMoveKnightradioButton.Size = new System.Drawing.Size(134, 17);
            this.RookMoveKnightradioButton.TabIndex = 1;
            this.RookMoveKnightradioButton.TabStop = true;
            this.RookMoveKnightradioButton.Text = "Rook + Move % Knight";
            this.RookMoveKnightradioButton.UseVisualStyleBackColor = true;
            this.RookMoveKnightradioButton.CheckedChanged += new System.EventHandler(this.RookMoveKnightradioButton_CheckedChanged);
            // 
            // KnightradioButton
            // 
            this.KnightradioButton.AutoSize = true;
            this.KnightradioButton.Location = new System.Drawing.Point(36, 173);
            this.KnightradioButton.Name = "KnightradioButton";
            this.KnightradioButton.Size = new System.Drawing.Size(55, 17);
            this.KnightradioButton.TabIndex = 1;
            this.KnightradioButton.TabStop = true;
            this.KnightradioButton.Text = "Knight";
            this.KnightradioButton.UseVisualStyleBackColor = true;
            this.KnightradioButton.CheckedChanged += new System.EventHandler(this.KnightradioButton_CheckedChanged);
            // 
            // KnightMoveradioButton
            // 
            this.KnightMoveradioButton.AutoSize = true;
            this.KnightMoveradioButton.Location = new System.Drawing.Point(36, 196);
            this.KnightMoveradioButton.Name = "KnightMoveradioButton";
            this.KnightMoveradioButton.Size = new System.Drawing.Size(94, 17);
            this.KnightMoveradioButton.TabIndex = 1;
            this.KnightMoveradioButton.TabStop = true;
            this.KnightMoveradioButton.Text = "Knight + Move";
            this.KnightMoveradioButton.UseVisualStyleBackColor = true;
            this.KnightMoveradioButton.CheckedChanged += new System.EventHandler(this.KnightMoveradioButton_CheckedChanged);
            // 
            // RookradioButton
            // 
            this.RookradioButton.AutoSize = true;
            this.RookradioButton.Location = new System.Drawing.Point(36, 219);
            this.RookradioButton.Name = "RookradioButton";
            this.RookradioButton.Size = new System.Drawing.Size(51, 17);
            this.RookradioButton.TabIndex = 1;
            this.RookradioButton.TabStop = true;
            this.RookradioButton.Text = "Rook";
            this.RookradioButton.UseVisualStyleBackColor = true;
            this.RookradioButton.CheckedChanged += new System.EventHandler(this.RookradioButton_CheckedChanged);
            // 
            // RookMoveradioButton
            // 
            this.RookMoveradioButton.AutoSize = true;
            this.RookMoveradioButton.Location = new System.Drawing.Point(36, 242);
            this.RookMoveradioButton.Name = "RookMoveradioButton";
            this.RookMoveradioButton.Size = new System.Drawing.Size(90, 17);
            this.RookMoveradioButton.TabIndex = 1;
            this.RookMoveradioButton.TabStop = true;
            this.RookMoveradioButton.Text = "Rook + Move";
            this.RookMoveradioButton.UseVisualStyleBackColor = true;
            this.RookMoveradioButton.CheckedChanged += new System.EventHandler(this.RookMoveradioButton_CheckedChanged);
            // 
            // Rook_2_KnightradioButton
            // 
            this.Rook_2_KnightradioButton.AutoSize = true;
            this.Rook_2_KnightradioButton.Location = new System.Drawing.Point(36, 265);
            this.Rook_2_KnightradioButton.Name = "Rook_2_KnightradioButton";
            this.Rook_2_KnightradioButton.Size = new System.Drawing.Size(93, 17);
            this.Rook_2_KnightradioButton.TabIndex = 1;
            this.Rook_2_KnightradioButton.TabStop = true;
            this.Rook_2_KnightradioButton.Text = "Rook + Knight";
            this.Rook_2_KnightradioButton.UseVisualStyleBackColor = true;
            this.Rook_2_KnightradioButton.CheckedChanged += new System.EventHandler(this.Rook_2_KnightradioButton_CheckedChanged);
            // 
            // QueenKnightradioButton
            // 
            this.QueenKnightradioButton.AutoSize = true;
            this.QueenKnightradioButton.Location = new System.Drawing.Point(36, 288);
            this.QueenKnightradioButton.Name = "QueenKnightradioButton";
            this.QueenKnightradioButton.Size = new System.Drawing.Size(101, 17);
            this.QueenKnightradioButton.TabIndex = 1;
            this.QueenKnightradioButton.TabStop = true;
            this.QueenKnightradioButton.Text = "Queen % Knight";
            this.QueenKnightradioButton.UseVisualStyleBackColor = true;
            this.QueenKnightradioButton.CheckedChanged += new System.EventHandler(this.QueenKnightradioButton_CheckedChanged);
            // 
            // QueenradioButton
            // 
            this.QueenradioButton.AutoSize = true;
            this.QueenradioButton.Location = new System.Drawing.Point(36, 311);
            this.QueenradioButton.Name = "QueenradioButton";
            this.QueenradioButton.Size = new System.Drawing.Size(57, 17);
            this.QueenradioButton.TabIndex = 1;
            this.QueenradioButton.TabStop = true;
            this.QueenradioButton.Text = "Queen";
            this.QueenradioButton.UseVisualStyleBackColor = true;
            this.QueenradioButton.CheckedChanged += new System.EventHandler(this.QueenradioButton_CheckedChanged);
            // 
            // QueenMoveradioButton
            // 
            this.QueenMoveradioButton.AutoSize = true;
            this.QueenMoveradioButton.Location = new System.Drawing.Point(36, 334);
            this.QueenMoveradioButton.Name = "QueenMoveradioButton";
            this.QueenMoveradioButton.Size = new System.Drawing.Size(96, 17);
            this.QueenMoveradioButton.TabIndex = 1;
            this.QueenMoveradioButton.TabStop = true;
            this.QueenMoveradioButton.Text = "Queen + Move";
            this.QueenMoveradioButton.UseVisualStyleBackColor = true;
            this.QueenMoveradioButton.CheckedChanged += new System.EventHandler(this.QueenMoveradioButton_CheckedChanged);
            // 
            // HandiCapPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 404);
            this.Controls.Add(this.QueenMoveradioButton);
            this.Controls.Add(this.QueenradioButton);
            this.Controls.Add(this.QueenKnightradioButton);
            this.Controls.Add(this.Rook_2_KnightradioButton);
            this.Controls.Add(this.RookMoveradioButton);
            this.Controls.Add(this.RookradioButton);
            this.Controls.Add(this.KnightMoveradioButton);
            this.Controls.Add(this.KnightradioButton);
            this.Controls.Add(this.RookMoveKnightradioButton);
            this.Controls.Add(this.RookKnightradioButton);
            this.Controls.Add(this.Pawn_f7_3_MovesradioButton);
            this.Controls.Add(this.Pawn_f7_2_MovesradioButton);
            this.Controls.Add(this.Pawn_f7_MoveradioButton);
            this.Controls.Add(this.PawnMoveradioButton);
            this.Controls.Add(this.PawnradioButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandiCapPositionForm";
            this.Text = "Handicap Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton PawnradioButton;
        private System.Windows.Forms.RadioButton PawnMoveradioButton;
        private System.Windows.Forms.RadioButton Pawn_f7_MoveradioButton;
        private System.Windows.Forms.RadioButton Pawn_f7_2_MovesradioButton;
        private System.Windows.Forms.RadioButton Pawn_f7_3_MovesradioButton;
        private System.Windows.Forms.RadioButton RookKnightradioButton;
        private System.Windows.Forms.RadioButton RookMoveKnightradioButton;
        private System.Windows.Forms.RadioButton KnightradioButton;
        private System.Windows.Forms.RadioButton KnightMoveradioButton;
        private System.Windows.Forms.RadioButton RookradioButton;
        private System.Windows.Forms.RadioButton RookMoveradioButton;
        private System.Windows.Forms.RadioButton Rook_2_KnightradioButton;
        private System.Windows.Forms.RadioButton QueenKnightradioButton;
        private System.Windows.Forms.RadioButton QueenradioButton;
        private System.Windows.Forms.RadioButton QueenMoveradioButton;
    }
}