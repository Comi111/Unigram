﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile ActionVoice.json
//       
//       Input file:
//           ActionVoice.json (3579 bytes created 16:38+01:00 Dec 22 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ___________________________________________________________
// |       Object stats       | UAP v11 count | UAP v7 count |
// |__________________________|_______________|______________|
// | All CompositionObjects   |            48 |           36 |
// |--------------------------+---------------+--------------|
// | Expression animators     |             5 |            2 |
// | KeyFrame animators       |             5 |            2 |
// | Reference parameters     |             5 |            2 |
// | Expression operations    |             0 |            0 |
// |--------------------------+---------------+--------------|
// | Animated brushes         |             2 |            2 |
// | Animated gradient stops  |             - |            - |
// | ExpressionAnimations     |             1 |            1 |
// | PathKeyFrameAnimations   |             3 |            - |
// |--------------------------+---------------+--------------|
// | ContainerVisuals         |             1 |            1 |
// | ShapeVisuals             |             1 |            1 |
// |--------------------------+---------------+--------------|
// | ContainerShapes          |             - |            - |
// | CompositionSpriteShapes  |             3 |            3 |
// |--------------------------+---------------+--------------|
// | Brushes                  |             3 |            3 |
// | Gradient stops           |             - |            - |
// | CompositionVisualSurface |             - |            - |
// -----------------------------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        u_recording_voice
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    public sealed class ActionVoice
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.500 seconds.
        internal const long c_durationTicks = 5000000;
        internal readonly Color m_foreground;

        public ActionVoice(Color foreground)
        {
            m_foreground = foreground;
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (ActionVoice_AnimatedVisual_UAPv11.IsRuntimeCompatible())
            {
                return
                    new ActionVoice_AnimatedVisual_UAPv11(
                        compositor,
                        m_foreground
                        );
            }

            if (ActionVoice_AnimatedVisual_UAPv7.IsRuntimeCompatible())
            {
                return
                    new ActionVoice_AnimatedVisual_UAPv7(
                        compositor,
                        m_foreground
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 30d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 30d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class ActionVoice_AnimatedVisual_UAPv11 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly Color _f;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            // - Path
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-3.35700011F, 37.9889984F));
                    builder.AddCubicBezier(new Vector2(0.995999992F, 26.1539993F), new Vector2(3.37199998F, 13.3649998F), new Vector2(3.37199998F, 0.0199999996F));
                    builder.AddCubicBezier(new Vector2(3.37199998F, -13.3400002F), new Vector2(0.99000001F, -26.1429996F), new Vector2(-3.37199998F, -37.9889984F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            // - Path
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(35.5209999F, 49.6629982F));
                    builder.AddCubicBezier(new Vector2(40.6170006F, 34.0349998F), new Vector2(43.3720016F, 17.3490009F), new Vector2(43.3720016F, 0.0199999996F));
                    builder.AddCubicBezier(new Vector2(43.3720016F, -17.3040009F), new Vector2(40.6189995F, -33.9840012F), new Vector2(35.526001F, -49.6080017F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2 Offset:<76.985, 109.973>
            // - Path
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-2.98900008F, 26.2210007F));
                    builder.AddCubicBezier(new Vector2(0.85799998F, 18.3059998F), new Vector2(3.0150001F, 9.41800022F), new Vector2(3.0150001F, 0.0270000007F));
                    builder.AddCubicBezier(new Vector2(3.0150001F, -9.38599968F), new Vector2(0.84799999F, -18.2919998F), new Vector2(-3.0150001F, -26.2210007F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2 Offset:<76.985, 109.973>
            // - Path
            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(36.2869987F, 37.9959984F));
                    builder.AddCubicBezier(new Vector2(40.6389999F, 26.1609993F), new Vector2(43.0149994F, 13.3719997F), new Vector2(43.0149994F, 0.0270000007F));
                    builder.AddCubicBezier(new Vector2(43.0149994F, -13.3330002F), new Vector2(40.6339989F, -26.1359997F), new Vector2(36.2719994F, -37.9819984F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            // - Path
            CanvasGeometry Geometry_4()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-1.00199997F, 15.4160004F));
                    builder.AddCubicBezier(new Vector2(0.305000007F, 10.4910002F), new Vector2(1.00199997F, 5.31799984F), new Vector2(1.00199997F, -0.0189999994F));
                    builder.AddCubicBezier(new Vector2(1.00199997F, -5.34200001F), new Vector2(0.308999985F, -10.5030003F), new Vector2(-0.991999984F, -15.4160004F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            // - Path
            CanvasGeometry Geometry_5()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(34.9980011F, 26.1739998F));
                    builder.AddCubicBezier(new Vector2(38.8450012F, 18.2590008F), new Vector2(41.0019989F, 9.37199974F), new Vector2(41.0019989F, -0.0189999994F));
                    builder.AddCubicBezier(new Vector2(41.0019989F, -9.43200016F), new Vector2(38.8339996F, -18.3390007F), new Vector2(34.9710007F, -26.2679996F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            // Color
            ColorKeyFrameAnimation ColorAnimation_Black_to_Transparent()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0xFF, _f.R, _f.G, _f.B), _holdThenStepEasingFunction);
                // Frame 29.
                // Transparent
                result.InsertKeyFrame(0.966666639F, Color.FromArgb(0x00, _f.R, _f.G, _f.B), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            // Color
            ColorKeyFrameAnimation ColorAnimation_Transparent_to_Black()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x00, _f.R, _f.G, _f.B), _holdThenStepEasingFunction);
                // Frame 29.
                // Black
                result.InsertKeyFrame(0.966666639F, Color.FromArgb(0xFF, _f.R, _f.G, _f.B), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<116.628, 109.98>
            CompositionColorBrush AnimatedColorBrush_Black_to_Transparent()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_Black_to_Transparent(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<38.998, 110.019>
            CompositionColorBrush AnimatedColorBrush_Transparent_to_Black()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_Transparent_to_Black(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2 Offset:<76.985, 109.973>
            CompositionColorBrush ColorBrush_Black()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, _f.R, _f.G, _f.B));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<116.628, 109.98>
            CompositionPathGeometry PathGeometry_0()
            {
                var result = _c.CreatePathGeometry();
                StartProgressBoundAnimation(result, "Path", PathKeyFrameAnimation_0(), RootProgress());
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2 Offset:<76.985, 109.973>
            CompositionPathGeometry PathGeometry_1()
            {
                var result = _c.CreatePathGeometry();
                StartProgressBoundAnimation(result, "Path", PathKeyFrameAnimation_1(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<38.998, 110.019>
            CompositionPathGeometry PathGeometry_2()
            {
                var result = _c.CreatePathGeometry();
                StartProgressBoundAnimation(result, "Path", PathKeyFrameAnimation_2(), _rootProgress);
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<116.628, 109.98>
                var result = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(1F, 0F, 0F, 1F, 116.627998F, 109.980003F));
                result.StrokeBrush = AnimatedColorBrush_Black_to_Transparent();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<76.985, 109.973>
                var result = CreateSpriteShape(PathGeometry_1(), new Matrix3x2(1F, 0F, 0F, 1F, 76.9850006F, 109.973F));
                result.StrokeBrush = ColorBrush_Black();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<38.998, 110.019>
                var result = CreateSpriteShape(PathGeometry_2(), new Matrix3x2(1F, 0F, 0F, 1F, 38.9980011F, 110.018997F));
                result.StrokeBrush = AnimatedColorBrush_Transparent_to_Black();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_0()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_0()), HoldThenStepEasingFunction());
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new CompositionPath(Geometry_1()), CubicBezierEasingFunction_0());
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2 Offset:<76.985, 109.973>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_1()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_2()), _holdThenStepEasingFunction);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new CompositionPath(Geometry_3()), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_2()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_4()), _holdThenStepEasingFunction);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new CompositionPath(Geometry_5()), _cubicBezierEasingFunction_0);
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 3 Offset:<116.628, 109.98>
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2 Offset:<76.985, 109.973>
                shapes.Add(SpriteShape_1());
                // ShapeGroup: Group 1 Offset:<38.998, 110.019>
                shapes.Add(SpriteShape_2());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            internal ActionVoice_AnimatedVisual_UAPv11(
                Compositor compositor,
                Color foreground
                )
            {
                _c = compositor;
                _f = foreground;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 11);
            }
        }

        sealed class ActionVoice_AnimatedVisual_UAPv7 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly Color _f;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-3.35700011F, 37.9889984F));
                    builder.AddCubicBezier(new Vector2(0.995999992F, 26.1539993F), new Vector2(3.37199998F, 13.3649998F), new Vector2(3.37199998F, 0.0199999996F));
                    builder.AddCubicBezier(new Vector2(3.37199998F, -13.3400002F), new Vector2(0.99000001F, -26.1429996F), new Vector2(-3.37199998F, -37.9889984F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 2 Offset:<76.985, 109.973>
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-2.98900008F, 26.2210007F));
                    builder.AddCubicBezier(new Vector2(0.85799998F, 18.3059998F), new Vector2(3.0150001F, 9.41800022F), new Vector2(3.0150001F, 0.0270000007F));
                    builder.AddCubicBezier(new Vector2(3.0150001F, -9.38599968F), new Vector2(0.84799999F, -18.2919998F), new Vector2(-3.0150001F, -26.2210007F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-1.00199997F, 15.4160004F));
                    builder.AddCubicBezier(new Vector2(0.305000007F, 10.4910002F), new Vector2(1.00199997F, 5.31799984F), new Vector2(1.00199997F, -0.0189999994F));
                    builder.AddCubicBezier(new Vector2(1.00199997F, -5.34200001F), new Vector2(0.308999985F, -10.5030003F), new Vector2(-0.991999984F, -15.4160004F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 3 Offset:<116.628, 109.98>
            // Color
            ColorKeyFrameAnimation ColorAnimation_Black_to_Transparent()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0xFF, _f.R, _f.G, _f.B), HoldThenStepEasingFunction());
                // Frame 29.
                // Transparent
                result.InsertKeyFrame(0.966666639F, Color.FromArgb(0x00, _f.R, _f.G, _f.B), CubicBezierEasingFunction_0());
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1 Offset:<38.998, 110.019>
            // Color
            ColorKeyFrameAnimation ColorAnimation_Transparent_to_Black()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x00, _f.R, _f.G, _f.B), _holdThenStepEasingFunction);
                // Frame 29.
                // Black
                result.InsertKeyFrame(0.966666639F, Color.FromArgb(0xFF, _f.R, _f.G, _f.B), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<116.628, 109.98>
            CompositionColorBrush AnimatedColorBrush_Black_to_Transparent()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_Black_to_Transparent(), RootProgress());
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<38.998, 110.019>
            CompositionColorBrush AnimatedColorBrush_Transparent_to_Black()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_Transparent_to_Black(), _rootProgress);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2 Offset:<76.985, 109.973>
            CompositionColorBrush ColorBrush_Black()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, _f.R, _f.G, _f.B));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 3 Offset:<116.628, 109.98>
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2 Offset:<76.985, 109.973>
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1 Offset:<38.998, 110.019>
            CompositionPathGeometry PathGeometry_2()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_2()));
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<116.628, 109.98>
                var result = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(1F, 0F, 0F, 1F, 116.627998F, 109.980003F));
                result.StrokeBrush = AnimatedColorBrush_Black_to_Transparent();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<76.985, 109.973>
                var result = CreateSpriteShape(PathGeometry_1(), new Matrix3x2(1F, 0F, 0F, 1F, 76.9850006F, 109.973F));
                result.StrokeBrush = ColorBrush_Black();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<38.998, 110.019>
                var result = CreateSpriteShape(PathGeometry_2(), new Matrix3x2(1F, 0F, 0F, 1F, 38.9980011F, 110.018997F));
                result.StrokeBrush = AnimatedColorBrush_Transparent_to_Black();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 20F;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Shape tree root for layer: icon
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // Shape tree root for layer: icon
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // ShapeGroup: Group 3 Offset:<116.628, 109.98>
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 2 Offset:<76.985, 109.973>
                shapes.Add(SpriteShape_1());
                // ShapeGroup: Group 1 Offset:<38.998, 110.019>
                shapes.Add(SpriteShape_2());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            internal ActionVoice_AnimatedVisual_UAPv7(
                Compositor compositor,
                Color foreground
                )
            {
                _c = compositor;
                _f = foreground;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
