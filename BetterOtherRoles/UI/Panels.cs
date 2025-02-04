﻿using BetterOtherRoles.UI.Panels;

namespace BetterOtherRoles.UI;

public static partial class UIManager
{
    public static OverlayPanel Overlay { get; private set; }
    public static CustomOptionsPanel CustomOptionsPanel { get; private set; }
    public static LocalOptionsPanel LocalOptionsPanel { get; private set; }
    public static CreditsPanel CreditsPanel { get; private set; }
    public static StickyBombPanel StickyBombPanel { get; private set; }
    
    private static void InitPanels()
    {
        if (UiBase == null) return;

        Overlay = new OverlayPanel(UiBase);
        CustomOptionsPanel = new CustomOptionsPanel(UiBase);
        LocalOptionsPanel = new LocalOptionsPanel(UiBase);
        CreditsPanel = new CreditsPanel(UiBase);
        StickyBombPanel = new StickyBombPanel(UiBase);
    }

    public static void CloseAllPanels()
    {
        CustomOptionsPanel.SetActive(false);
        LocalOptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        StickyBombPanel.SetActive(false);
    }
}