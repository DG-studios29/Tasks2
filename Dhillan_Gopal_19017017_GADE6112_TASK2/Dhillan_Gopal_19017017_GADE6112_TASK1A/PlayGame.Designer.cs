namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	partial class PlayGame
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
			this.lblEnemiesRemaining = new System.Windows.Forms.Label();
			this.lblAttackingOptions = new System.Windows.Forms.Label();
			this.lblActionStatus = new System.Windows.Forms.Label();
			this.lblHeroStats = new System.Windows.Forms.Label();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.lblMapView = new System.Windows.Forms.Label();
			this.btnAttackUp = new System.Windows.Forms.Button();
			this.btnAttackLeft = new System.Windows.Forms.Button();
			this.btnAttackDown = new System.Windows.Forms.Button();
			this.btnAttackRight = new System.Windows.Forms.Button();
			this.btnSaveGame = new System.Windows.Forms.Button();
			this.lblAttackBtn = new System.Windows.Forms.Label();
			this.lblMoveBtn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblEnemiesRemaining
			// 
			this.lblEnemiesRemaining.AutoSize = true;
			this.lblEnemiesRemaining.Location = new System.Drawing.Point(26, 26);
			this.lblEnemiesRemaining.Name = "lblEnemiesRemaining";
			this.lblEnemiesRemaining.Size = new System.Drawing.Size(0, 17);
			this.lblEnemiesRemaining.TabIndex = 13;
			// 
			// lblAttackingOptions
			// 
			this.lblAttackingOptions.AutoSize = true;
			this.lblAttackingOptions.Location = new System.Drawing.Point(588, 26);
			this.lblAttackingOptions.Name = "lblAttackingOptions";
			this.lblAttackingOptions.Size = new System.Drawing.Size(0, 17);
			this.lblAttackingOptions.TabIndex = 14;
			// 
			// lblActionStatus
			// 
			this.lblActionStatus.AutoSize = true;
			this.lblActionStatus.Location = new System.Drawing.Point(894, 26);
			this.lblActionStatus.Name = "lblActionStatus";
			this.lblActionStatus.Size = new System.Drawing.Size(0, 17);
			this.lblActionStatus.TabIndex = 15;
			// 
			// lblHeroStats
			// 
			this.lblHeroStats.AutoSize = true;
			this.lblHeroStats.Location = new System.Drawing.Point(244, 12);
			this.lblHeroStats.Name = "lblHeroStats";
			this.lblHeroStats.Size = new System.Drawing.Size(0, 17);
			this.lblHeroStats.TabIndex = 16;
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(1156, 619);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(112, 100);
			this.btnRight.TabIndex = 8;
			this.btnRight.Text = "Right >";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click_1);
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(1026, 502);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(112, 100);
			this.btnUp.TabIndex = 9;
			this.btnUp.Text = "Up /\\";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click_1);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(1026, 619);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(112, 100);
			this.btnDown.TabIndex = 10;
			this.btnDown.Text = "Down \\/";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click_1);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(897, 619);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(112, 100);
			this.btnLeft.TabIndex = 11;
			this.btnLeft.Text = "< Left";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
			// 
			// lblMapView
			// 
			this.lblMapView.AutoSize = true;
			this.lblMapView.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMapView.Location = new System.Drawing.Point(550, 135);
			this.lblMapView.Name = "lblMapView";
			this.lblMapView.Size = new System.Drawing.Size(0, 22);
			this.lblMapView.TabIndex = 17;
			// 
			// btnAttackUp
			// 
			this.btnAttackUp.Location = new System.Drawing.Point(247, 502);
			this.btnAttackUp.Name = "btnAttackUp";
			this.btnAttackUp.Size = new System.Drawing.Size(110, 100);
			this.btnAttackUp.TabIndex = 18;
			this.btnAttackUp.Text = "Up /\\";
			this.btnAttackUp.UseVisualStyleBackColor = true;
			this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
			// 
			// btnAttackLeft
			// 
			this.btnAttackLeft.Location = new System.Drawing.Point(109, 619);
			this.btnAttackLeft.Name = "btnAttackLeft";
			this.btnAttackLeft.Size = new System.Drawing.Size(110, 100);
			this.btnAttackLeft.TabIndex = 18;
			this.btnAttackLeft.Text = "< Left";
			this.btnAttackLeft.UseVisualStyleBackColor = true;
			this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
			// 
			// btnAttackDown
			// 
			this.btnAttackDown.Location = new System.Drawing.Point(247, 619);
			this.btnAttackDown.Name = "btnAttackDown";
			this.btnAttackDown.Size = new System.Drawing.Size(110, 100);
			this.btnAttackDown.TabIndex = 18;
			this.btnAttackDown.Text = "Down \\/";
			this.btnAttackDown.UseVisualStyleBackColor = true;
			this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
			// 
			// btnAttackRight
			// 
			this.btnAttackRight.Location = new System.Drawing.Point(383, 619);
			this.btnAttackRight.Name = "btnAttackRight";
			this.btnAttackRight.Size = new System.Drawing.Size(110, 100);
			this.btnAttackRight.TabIndex = 18;
			this.btnAttackRight.Text = "Right >";
			this.btnAttackRight.UseVisualStyleBackColor = true;
			this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
			// 
			// btnSaveGame
			// 
			this.btnSaveGame.Location = new System.Drawing.Point(1216, 12);
			this.btnSaveGame.Name = "btnSaveGame";
			this.btnSaveGame.Size = new System.Drawing.Size(141, 84);
			this.btnSaveGame.TabIndex = 19;
			this.btnSaveGame.Text = "Save Game";
			this.btnSaveGame.UseVisualStyleBackColor = true;
			this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
			// 
			// lblAttackBtn
			// 
			this.lblAttackBtn.AutoSize = true;
			this.lblAttackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAttackBtn.Location = new System.Drawing.Point(209, 446);
			this.lblAttackBtn.Name = "lblAttackBtn";
			this.lblAttackBtn.Size = new System.Drawing.Size(198, 32);
			this.lblAttackBtn.TabIndex = 20;
			this.lblAttackBtn.Text = "Attack Buttons";
			// 
			// lblMoveBtn
			// 
			this.lblMoveBtn.AutoSize = true;
			this.lblMoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoveBtn.Location = new System.Drawing.Point(986, 446);
			this.lblMoveBtn.Name = "lblMoveBtn";
			this.lblMoveBtn.Size = new System.Drawing.Size(188, 32);
			this.lblMoveBtn.TabIndex = 20;
			this.lblMoveBtn.Text = "Move Buttons";
			// 
			// PlayGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1369, 749);
			this.Controls.Add(this.lblMoveBtn);
			this.Controls.Add(this.lblAttackBtn);
			this.Controls.Add(this.btnSaveGame);
			this.Controls.Add(this.btnAttackRight);
			this.Controls.Add(this.btnAttackDown);
			this.Controls.Add(this.btnAttackLeft);
			this.Controls.Add(this.btnAttackUp);
			this.Controls.Add(this.lblMapView);
			this.Controls.Add(this.lblEnemiesRemaining);
			this.Controls.Add(this.lblAttackingOptions);
			this.Controls.Add(this.lblActionStatus);
			this.Controls.Add(this.lblHeroStats);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnLeft);
			this.Name = "PlayGame";
			this.Text = "PlayGame";
			this.Load += new System.EventHandler(this.PlayGame_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEnemiesRemaining;
		private System.Windows.Forms.Label lblAttackingOptions;
		private System.Windows.Forms.Label lblActionStatus;
		private System.Windows.Forms.Label lblHeroStats;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Label lblMapView;
		private System.Windows.Forms.Button btnAttackUp;
		private System.Windows.Forms.Button btnAttackLeft;
		private System.Windows.Forms.Button btnAttackDown;
		private System.Windows.Forms.Button btnAttackRight;
		private System.Windows.Forms.Button btnSaveGame;
		private System.Windows.Forms.Label lblAttackBtn;
		private System.Windows.Forms.Label lblMoveBtn;
	}
}