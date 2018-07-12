// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Input;
using OpenTK;

namespace osu.Framework.Event
{
    public class MouseMoveEvent : MouseEvent
    {
        /// <summary>
        /// The last mouse position before this mouse move in the screen space.
        /// </summary>
        public Vector2 ScreenSpaceLastMousePosition;

        /// <summary>
        /// The last mouse position before this mouse move in local space.
        /// </summary>
        public Vector2 LastMousePosition => ToLocalSpace(ScreenSpaceLastMousePosition);

        /// <summary>
        /// The difference of mouse position from last position to current position in local space.
        /// </summary>
        public Vector2 Delta => MousePosition - LastMousePosition;

        public MouseMoveEvent(InputState state)
            : base(state)
        {
            ScreenSpaceLastMousePosition = ScreenSpaceMousePosition;
        }
    }
}
