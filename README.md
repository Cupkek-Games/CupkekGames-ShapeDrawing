# CupkekGames ShapeDrawing

Pooled indicator/shape-drawing primitives. Provides the abstract `Indicator` base + `IndicatorPool` that hosts concrete shape implementations.

## What's inside

**Runtime** (`CupkekGames.ShapeDrawing.asmdef`)

- `Indicator` (abstract MonoBehaviour) — single positionable indicator with a `Color` setter.
- `IndicatorPool` — pooled spawner of any `Indicator` subtype.

Concrete indicator shapes live in `com.cupkekgames.shapedrawing.shapes`.

## Dependencies

Asmdef references resolve via the CupkekGames scoped registry: `services`, `pool`, `units`, `character`, `vfx`. Bring your own copy via the registry.
