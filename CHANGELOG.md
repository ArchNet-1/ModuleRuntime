# Changelog

## [2.0.0] - 2026-11-25

Unity 6 release.

### Changed
- Requires Unity 6000.0 or newer.
- Code split into `Runtime/` (game code) and `Editor/` (Editor-only assembly, never in builds).
- Namespace `ArchNet.<Category>`; every file starts with a short description and a link to the documentation.
- Files moved with their `.meta`: existing scenes, prefabs and assets keep their references.
- Works with the new Input System (it threw an exception every frame).
- Text refreshed 4 times per second and only while visible.
- `Service` reduced to one method: `Read()`.
- `PlateformService` → `PlatformService`, class `Runtime` → `RuntimeModule`.
