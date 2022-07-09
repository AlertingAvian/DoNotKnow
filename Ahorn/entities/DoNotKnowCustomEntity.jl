module DoNotKnowCustomEntity
using ..Ahorn, Maple

sprite = "DoNotKnow/CustomEntity/idle/idle00"

@mapdef Entity "DoNotKnow/CustomEntity" CustomEntity(x::Integer, y::Integer)

const placements = Ahorn.PlacementDict(
    "CustomEntity" => Ahorn.EntityPlacement(
        CustomEntity,
        "point",
    )
)

Ahorn.render(ctx::Ahorn.Cairo.CairoContext, entitiy::CustomEntity, room::Maple.Room) = Ahorn.drawSprite(ctx, sprite, 0,0)

end