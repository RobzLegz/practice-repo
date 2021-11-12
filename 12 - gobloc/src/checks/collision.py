def collision_test(rect, tiles):
    collisions = []
    for tile in tiles:
        if rect.colliderect(tile):
            collisions.append(tile)
    return collisions