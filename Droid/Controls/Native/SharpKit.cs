using System;
using Android.Graphics;

namespace SharpPaintCode.Droid.Controls.Native
{
    public class SharpKit
    {
        // Resizing Behavior
        public enum ResizingBehavior
        {
            AspectFit, //!< The content is proportionally resized to fit into the target rectangle.
            AspectFill, //!< The content is proportionally resized to completely fill the target rectangle.
            Stretch, //!< The content is stretched to match the entire target rectangle.
            Center, //!< The content is centered in the target rectangle, but it is NOT resized.
        }

        // Canvas Drawings
        // Sharp

        private static class CacheForSharpCanvas
        {
            public static Paint paint = new Paint();
            public static RectF originalFrame = new RectF(0f, 0f, 100f, 100f);
            public static RectF resizedFrame = new RectF();
            public static RectF sharpFrame = new RectF();
            public static RectF sharpSymbolRect = new RectF();
            public static Path sharpSymbolPath = new Path();
        }

        public static void DrawSharpCanvas(Canvas canvas, int fillColor, float width, float height)
        {
            SharpKit.DrawSharpCanvas(canvas, new RectF(0f, 0f, 100f, 100f), ResizingBehavior.AspectFit, fillColor, width, height);
        }

        public static void DrawSharpCanvas(Canvas canvas, RectF targetFrame, ResizingBehavior resizing, int fillColor, float width, float height)
        {
            // General Declarations
            Paint paint = CacheForSharpCanvas.paint;

            // Resize to Target Frame
            canvas.Save();
            RectF resizedFrame = CacheForSharpCanvas.resizedFrame;
            SharpKit.resizingBehaviorApply(resizing, CacheForSharpCanvas.originalFrame, targetFrame, resizedFrame);
            canvas.Translate(resizedFrame.Left, resizedFrame.Top);
            canvas.Scale(resizedFrame.Width() / 100f, resizedFrame.Height() / 100f);

            // SharpFrame
            RectF sharpFrame = CacheForSharpCanvas.sharpFrame;
            sharpFrame.Set(0f, 0f, width, height);

            // SharpSymbol
            RectF sharpSymbolRect = CacheForSharpCanvas.sharpSymbolRect;
            sharpSymbolRect.Set(0f, 0f, 100f, 100f);
            Path sharpSymbolPath = CacheForSharpCanvas.sharpSymbolPath;
            sharpSymbolPath.Reset();
            sharpSymbolPath.MoveTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.00002f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top, sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.08245f, sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width(), sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width(), sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.46586f, sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.53414f, sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width(), sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width(), sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.91755f, sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height(), sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height());
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height());
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height(), sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.91755f, sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.91755f, sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height(), sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height());
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height());
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height(), sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.91755f, sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.LineTo(sharpFrame.Left, sharpFrame.Top + sharpFrame.Height() * 0.8f);
            sharpSymbolPath.LineTo(sharpFrame.Left, sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.53414f, sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.46586f, sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.LineTo(sharpFrame.Left, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.LineTo(sharpFrame.Left, sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top + sharpFrame.Height() * 0.08245f, sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top, sharpFrame.Left + sharpFrame.Width() * 0.2f, sharpFrame.Top);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top, sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.08245f, sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.2f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.08245f, sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top, sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.8f, sharpFrame.Top + sharpFrame.Height() * 0.00002f);
            sharpSymbolPath.Close();
            sharpSymbolPath.MoveTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.46586f, sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.53414f, sharpFrame.Left + sharpFrame.Width() * 0.4f, sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.LineTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.6f);
            sharpSymbolPath.CubicTo(sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.53414f, sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.46586f, sharpFrame.Left + sharpFrame.Width() * 0.6f, sharpFrame.Top + sharpFrame.Height() * 0.4f);
            sharpSymbolPath.Close();

            paint.Reset();
            paint.Flags = PaintFlags.AntiAlias;
            paint.SetStyle(Paint.Style.Fill);
            paint.Color = new Color(fillColor);
            canvas.DrawPath(sharpSymbolPath, paint);

            canvas.Restore();
        }


        // Resizing Behavior
        public static void resizingBehaviorApply(ResizingBehavior behavior, RectF rect, RectF target, RectF result)
        {
            if (rect.Equals(target) || target == null)
            {
                result.Set(rect);
                return;
            }

            if (behavior == ResizingBehavior.Stretch)
            {
                result.Set(target);
                return;
            }

            float xRatio = Math.Abs(target.Width() / rect.Width());
            float yRatio = Math.Abs(target.Height() / rect.Height());
            float scale = 0f;

            switch (behavior)
            {
                case ResizingBehavior.AspectFit:
                    {
                        scale = Math.Min(xRatio, yRatio);
                        break;
                    }
                case ResizingBehavior.AspectFill:
                    {
                        scale = Math.Max(xRatio, yRatio);
                        break;
                    }
                case ResizingBehavior.Center:
                    {
                        scale = 1f;
                        break;
                    }
            }

            float newWidth = Math.Abs(rect.Width() * scale);
            float newHeight = Math.Abs(rect.Height() * scale);
            result.Set(target.CenterX() - newWidth / 2,
                       target.CenterY() - newHeight / 2,
                       target.CenterX() + newWidth / 2,
                       target.CenterY() + newHeight / 2);
        }

    }
}