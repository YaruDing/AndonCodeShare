/// <summary>
/// 折线图绘制
/// </summary>
/// <param name="picBox">主体展示PictureBox</param>
/// <param name="pointX">pictureBox location-X</param>
/// <param name="pointY">pictureBox location-Y</param>
/// <param name="width">pictureBox Width</param>
/// <param name="height">pictureBox Height</param>
/// <param name="titleText">标题</param>
/// <param name="startX">坐标轴X</param>
/// <param name="startY">坐标轴Y</param>
/// <param name="disW">坐标轴 宽度间距</param>
/// <param name="disH">坐标轴 高度间距</param>
/// <param name="horizontalText">横坐标 文本</param>
/// <param name="verticalText">纵坐标 文本</param>
/// 外部变量 Color[] colors 

private void CreateImage(PictureBox picBox, int pointX, int pointY, int width, int height, string titleText, int startX, int startY, int disW, int disH, string[] horizontalText, string[] verticalText,string[] tuLiText, int[][] values)
{
    picBox.Visible = true;
    picBox.Size = new System.Drawing.Size(width, height);
    picBox.Location = new Point(pointX, pointY);

    Bitmap image = new Bitmap(width, height);
    Graphics gra = Graphics.FromImage(image);

    Font titleFont = new Font("宋体", 20, FontStyle.Regular);
    Font cordFont = new Font("宋体", 10, FontStyle.Regular);
    Font tuLiFont = new Font("宋体", 12, FontStyle.Regular);
    Brush blueBrush = new SolidBrush(Color.Blue);
    Brush blackBrush = new SolidBrush(Color.Black);

    picBox.Image = image;

    try {
        gra.Clear(Color.FromArgb(102, 135, 175));
        gra.DrawRectangle(new Pen(Color.Black), 0, 0, image.Width - 1, image.Height - 1);
        SizeF titleSize = gra.MeasureString(titleText, titleFont);
        //标题
        gra.DrawString(titleText, titleFont, blackBrush, new PointF(width / 2 - titleSize.Width / 2, 3));

        //图例
        int tuliX = width - 30;
        for (int i = 0; i < tuLiText.Length; i++)
        {
            SizeF cordSize = gra.MeasureString("---" + tuLiText[i], tuLiFont);

            gra.DrawString("---" + tuLiText[i], tuLiFont, new SolidBrush(colors[i]), new PointF(tuliX - cordSize.Width, 5));
            tuliX = tuliX - Convert.ToInt32(cordSize.Width) - 3;
        }

        // startX + i * disW    
        // height - startY  disH  

        //纵轴
        for (int i = 0; i < horizontalText.Length; i++)
        {
            gra.DrawLine(new Pen(Color.Black, 1), startX + i * disW, height - startY, startX + i * disW, titleSize.Height + 3);

            SizeF cordSize = gra.MeasureString(horizontalText[i], cordFont);

            gra.DrawString(horizontalText[i], cordFont, blackBrush, new PointF(startX + i * disW - cordSize.Width / 2, height - startY + cordSize.Height));
        }


        //横轴
        gra.DrawLine(new Pen(Color.Black, 1), startX, height - startY, width - 30, height - startY);

        for (int j = 0; j < verticalText.Length; j++)
        {
            gra.DrawLine(new Pen(Color.Black, 1), startX, height - startY - (j + 1) * disH, width - 30, height - startY - (j + 1) * disH);

            SizeF cordSize = gra.MeasureString(verticalText[j], cordFont);

            gra.DrawString(verticalText[j], cordFont, blackBrush, new PointF(startX - cordSize.Width, height - startY - (j + 1) * disH - cordSize.Width / 2));
        }

        //数据
        for (int devID = 0; devID < values.Length; devID++)
        {
            int maxLength = values[devID].Length > horizontalText.Length ? horizontalText.Length : values[devID].Length;

            Point[] points = new Point[maxLength];
            for (int k = 0; k < maxLength; k++)
            {
                points[k] = new Point(startX + disW/2 + k * disW, height - startY - Convert.ToInt32(disH / (Convert.ToDouble(verticalText[1]) - Convert.ToDouble(verticalText[0])) * values[devID][k]));
                gra.DrawString(values[devID][k].ToString(), cordFont, new SolidBrush(colors[devID]), new PointF(startX + disW / 2 + k * disW, height - startY - Convert.ToInt32(disH / (Convert.ToDouble(verticalText[1]) - Convert.ToDouble(verticalText[0])) * values[devID][k])));
            }

            gra.DrawLines(new Pen(colors[devID], 2), points);
        }

                
    }
    catch (Exception ex)
    { }
}

