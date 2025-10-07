namespace AOC._2024.Components.Layout;

using MudBlazor;

public class AdventOfCodeTheme : MudTheme
{
    public AdventOfCodeTheme()
    {
        PaletteDark = new PaletteDark
        {
            Primary = "#4FC846",
            Secondary = "#C0C0C0",
            Tertiary = "#FFD700",

            Info = "#5C8DFF",
            Success = "#4FC846",
            Warning = "#FFA726",
            Error = "#EF5350",

            Background = "#0A0F2C",
            Surface = "#111A40",
            DrawerBackground = "#111A40",
            DrawerText = "rgba(255,255,255, 0.87)",

            AppbarBackground = "#091430",
            AppbarText = "rgba(255,255,255, 0.92)",

            TextPrimary = "rgba(255,255,255,1.00)",
            TextSecondary = "rgba(255,255,255,0.70)",

            ActionDefault = "#4FC846",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",

            Divider = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",

            BackgroundGray = "#1D2A4C"
        };

        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "6px",
            DrawerWidthLeft = "260px",
            AppbarHeight = "56px"
        };

        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.0rem",
                FontWeight = "400",
                LineHeight = "1.5"
            },
            H1 = new H1Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "2.75rem",
                FontWeight = "700",
                LineHeight = "1.2"
            },
            H2 = new H2Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "2.25rem",
                FontWeight = "600",
                LineHeight = "1.3"
            },
            H3 = new H3Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.75rem",
                FontWeight = "600",
                LineHeight = "1.4"
            },
            H4 = new H4Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.5rem",
                FontWeight = "600",
                LineHeight = "1.4"
            },
            H5 = new H5Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.25rem",
                FontWeight = "500",
                LineHeight = "1.4"
            },
            H6 = new H6Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.0rem",
                FontWeight = "500",
                LineHeight = "1.5"
            },
            Subtitle1 = new Subtitle1Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.0rem",
                FontWeight = "500",
                LineHeight = "1.5"
            },
            Subtitle2 = new Subtitle2Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "0.9rem",
                FontWeight = "500",
                LineHeight = "1.5"
            },
            Body1 = new Body1Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "1.0rem",
                FontWeight = "400",
                LineHeight = "1.6"
            },
            Body2 = new Body2Typography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "0.9rem",
                FontWeight = "400",
                LineHeight = "1.6"
            },
            Button = new ButtonTypography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "0.95rem",
                FontWeight = "500",
                LineHeight = "1.5",
                TextTransform = "none"
            },
            Caption = new CaptionTypography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "0.8rem",
                FontWeight = "400",
                LineHeight = "1.4"
            },
            Overline = new OverlineTypography
            {
                FontFamily = new[] {"Inter", "Roboto", "sans-serif"},
                FontSize = "0.75rem",
                FontWeight = "400",
                LineHeight = "1.4",
                TextTransform = "none"
            }
        };
    }
}