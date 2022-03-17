﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Namespace Unigram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile Stickers.json
//       
//       Input file:
//           Stickers.json (4071 bytes created 17:41+01:00 Dec 21 2021)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    40 |
// |--------------------------+-------|
// | Expression animators     |     2 |
// | KeyFrame animators       |     2 |
// | Reference parameters     |     2 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     2 |
// |--------------------------+-------|
// | Brushes                  |     2 |
// | Gradient stops           |     4 |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Unigram.Assets.Icons
{
    // Name:        u_stickers
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    sealed class Stickers
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.500 seconds.
        internal const long c_durationTicks = 5000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Stickers_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Stickers_AnimatedVisual(
                        compositor
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
                { "NormalToPointerOver_Start", 0.0 },
                { "NormalToPointerOver_End", 1 },
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

        sealed class Stickers_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 2
            // - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_0()
            {
                var result = CanvasGeometry.CreateGroup(
                    null,
                    new CanvasGeometry[] { Geometry_1(), Geometry_2(), Geometry_3() },
                    CanvasFilledRegionDetermination.Winding);
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(20F, -20F));
                    builder.AddCubicBezier(new Vector2(20F, -25.5230007F), new Vector2(24.4769993F, -30F), new Vector2(30F, -30F));
                    builder.AddCubicBezier(new Vector2(35.5229988F, -30F), new Vector2(40F, -25.5230007F), new Vector2(40F, -20F));
                    builder.AddCubicBezier(new Vector2(40F, -14.4770002F), new Vector2(35.5229988F, -10F), new Vector2(30F, -10F));
                    builder.AddCubicBezier(new Vector2(24.4769993F, -10F), new Vector2(20F, -14.4770002F), new Vector2(20F, -20F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-40F, -20F));
                    builder.AddCubicBezier(new Vector2(-40F, -25.5230007F), new Vector2(-35.5229988F, -30F), new Vector2(-30F, -30F));
                    builder.AddCubicBezier(new Vector2(-24.4769993F, -30F), new Vector2(-20F, -25.5230007F), new Vector2(-20F, -20F));
                    builder.AddCubicBezier(new Vector2(-20F, -14.4770002F), new Vector2(-24.4769993F, -10F), new Vector2(-30F, -10F));
                    builder.AddCubicBezier(new Vector2(-35.5229988F, -10F), new Vector2(-40F, -14.4770002F), new Vector2(-40F, -20F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: icon
            // - - - ShapeGroup: Group 2
            // - - Path 3+Path 2+Path 1.PathGeometry
            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-78.8949966F, -49.3380013F));
                    builder.AddCubicBezier(new Vector2(-80F, -44.7340012F), new Vector2(-80F, -39.1559982F), new Vector2(-80F, -28F));
                    builder.AddLine(new Vector2(-80F, 28F));
                    builder.AddCubicBezier(new Vector2(-80F, 39.1559982F), new Vector2(-80F, 44.7340012F), new Vector2(-78.8949966F, 49.3380013F));
                    builder.AddCubicBezier(new Vector2(-75.3840027F, 63.9640007F), new Vector2(-63.9640007F, 75.3830032F), new Vector2(-49.3380013F, 78.8949966F));
                    builder.AddCubicBezier(new Vector2(-44.7340012F, 80F), new Vector2(-39.1559982F, 80F), new Vector2(-28F, 80F));
                    builder.AddLine(new Vector2(10F, 80F));
                    builder.AddLine(new Vector2(10.0179996F, 39.0730019F));
                    builder.AddCubicBezier(new Vector2(-7.0710001F, 42.2659988F), new Vector2(-25.3899994F, 37.2089996F), new Vector2(-38.5509987F, 23.9319992F));
                    builder.AddCubicBezier(new Vector2(-40.4949989F, 21.9710007F), new Vector2(-40.480999F, 18.8050003F), new Vector2(-38.5200005F, 16.8610001F));
                    builder.AddCubicBezier(new Vector2(-36.5589981F, 14.9169998F), new Vector2(-33.3930016F, 14.9309998F), new Vector2(-31.4489994F, 16.8920002F));
                    builder.AddCubicBezier(new Vector2(-19.8419991F, 28.6009998F), new Vector2(-3.31800008F, 32.4729996F), new Vector2(11.5319996F, 28.4540005F));
                    builder.AddCubicBezier(new Vector2(11.9099998F, 27.3059998F), new Vector2(12.3579998F, 26.2329998F), new Vector2(12.8760004F, 25.2380009F));
                    builder.AddCubicBezier(new Vector2(17.2849998F, 16.0990009F), new Vector2(25.2479992F, 10.7620001F), new Vector2(35.894001F, 10.0710001F));
                    builder.AddLine(new Vector2(37.7879982F, 10.0089998F));
                    builder.AddLine(new Vector2(80F, 10F));
                    builder.AddLine(new Vector2(80F, -28F));
                    builder.AddCubicBezier(new Vector2(80F, -39.1559982F), new Vector2(80F, -44.7340012F), new Vector2(78.8949966F, -49.3380013F));
                    builder.AddCubicBezier(new Vector2(75.3830032F, -63.9640007F), new Vector2(63.9640007F, -75.3840027F), new Vector2(49.3380013F, -78.8949966F));
                    builder.AddCubicBezier(new Vector2(44.7340012F, -80F), new Vector2(39.1559982F, -80F), new Vector2(28F, -80F));
                    builder.AddLine(new Vector2(-28F, -80F));
                    builder.AddCubicBezier(new Vector2(-39.1559982F, -80F), new Vector2(-44.7340012F, -80F), new Vector2(-49.3380013F, -78.8949966F));
                    builder.AddCubicBezier(new Vector2(-63.9640007F, -75.3840027F), new Vector2(-75.3840027F, -63.9640007F), new Vector2(-78.8949966F, -49.3380013F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: icon
            // - - ShapeGroup: Group 1
            CanvasGeometry Geometry_4()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(80F, 20.007F));
                    builder.AddCubicBezier(new Vector2(79.4140015F, 20.7700005F), new Vector2(78.776001F, 21.4969997F), new Vector2(78.0879974F, 22.1849995F));
                    builder.AddLine(new Vector2(22.184F, 78.0889969F));
                    builder.AddCubicBezier(new Vector2(21.5F, 78.7730026F), new Vector2(20.7759991F, 79.4089966F), new Vector2(20.0170002F, 79.9929962F));
                    builder.AddLine(new Vector2(20.007F, 37.4049988F));
                    builder.AddLine(new Vector2(20.066F, 35.9780006F));
                    builder.AddCubicBezier(new Vector2(20.7549992F, 27.5319996F), new Vector2(27.4740009F, 20.7900009F), new Vector2(35.9109993F, 20.0650005F));
                    builder.AddLine(new Vector2(37.4169998F, 20F));
                    builder.AddLine(new Vector2(80F, 20.007F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostDarkSeaGreen_FF78CD66()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x78, 0xCD, 0x66));
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostLightGreen_FFA4E797()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0xA4, 0xE7, 0x97));
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1
            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostForestGreen_FF439E36()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x43, 0x9E, 0x36));
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 2
            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostMediumSeaGreen_FF6CCA5F()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x6C, 0xCA, 0x5F));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            CompositionLinearGradientBrush LinearGradientBrush_0()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostLightGreen_FFA4E797());
                colorStops.Add(GradientStop_1_AlmostMediumSeaGreen_FF6CCA5F());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(0.967000008F, -78.7229996F);
                result.EndPoint = new Vector2(6.08199978F, 79.9020004F);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionLinearGradientBrush LinearGradientBrush_1()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostDarkSeaGreen_FF78CD66());
                colorStops.Add(GradientStop_1_AlmostForestGreen_FF439E36());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(47.1599998F, 19.8649998F);
                result.EndPoint = new Vector2(24.8010006F, 78.4489975F);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Path 3+Path 2+Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_4()));
            }

            // Shape tree root for layer: icon
            // Path 3+Path 2+Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry_0());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = LinearGradientBrush_0();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_0(), RootProgress());
                return result;
            }

            // Shape tree root for layer: icon
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(PathGeometry_1());
                result.Offset = new Vector2(100F, 100F);
                result.FillBrush = LinearGradientBrush_1();
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_1(), _rootProgress);
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
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F));
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
                // ShapeGroup: Group 2
                shapes.Add(SpriteShape_0());
                // ShapeGroup: Group 1
                shapes.Add(SpriteShape_1());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - - Shape tree root for layer: icon
            // - ShapeGroup: Group 1
            // Scale
            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 2
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 8.
                result.InsertKeyFrame(0.266666681F, new Vector2(1.12F, 1.12F), CubicBezierEasingFunction_0());
                // Frame 16.
                result.InsertKeyFrame(0.533333361F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 24.
                result.InsertKeyFrame(0.800000012F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Shape tree root for layer: icon
            // ShapeGroup: Group 1
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), StepThenHoldEasingFunction());
                // Frame 3.
                result.InsertKeyFrame(0.100000001F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                // Frame 11.
                result.InsertKeyFrame(0.366666675F, new Vector2(1.12F, 1.12F), _cubicBezierEasingFunction_0);
                // Frame 19.
                result.InsertKeyFrame(0.633333325F, new Vector2(0.949999988F, 0.949999988F), _cubicBezierEasingFunction_0);
                // Frame 27.
                result.InsertKeyFrame(0.899999976F, new Vector2(1F, 1F), _cubicBezierEasingFunction_0);
                return result;
            }

            internal Stickers_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
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
