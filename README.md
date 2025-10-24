# Shared Variables

## Summary

This Unity package helps decouple GameObjects by sharing data via ScriptableObjects, so they don't require direct access to each other.

This architecture is based on a talk by Ryan Hipple at Unite Austin 2017: https://www.youtube.com/watch?v=raQ3iHhE_Kk

## Dependencies

* **Odin Inspector *(optional)*:** https://assetstore.unity.com/packages/tools/utilities/odin-inspector-and-serializer-89041
* **Scene Reference Attribute:** https://github.com/KyleBanks/scene-ref-attribute

**Note:** If Odin Inspector was previously installed in the project, but has since been removed, please ensure that the `ODIN_INSPECTOR*` scripting define symbols have been removed from each platform in Player Settings. For details, see the "Custom symbols for a build profile" section of https://docs.unity3d.com/6000.2/Documentation/Manual/custom-scripting-symbols.html.
