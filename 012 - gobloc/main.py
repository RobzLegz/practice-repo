import pygame, sys
from pygame.locals import *
from src.variables.colors import *
from src.variables.screen import *
from src.variables.sprites import *
from src.checks.collision import *
from src.movement.sprite import *

main_clock = pygame.time.Clock()

pygame.init()
pygame.font.init()

tiles = [pygame.Rect(200, 350, 50, 50),pygame.Rect(260, 320, 50, 50)]

while 1:
    screen = pygame.display.set_mode([width, height])
    pygame.display.set_caption("GoBloc")
    screen.fill(BLACK)

    movement = [0,0]
    if right == True:
        movement[0] += 5
    if left == True:
        movement[0] -= 5
    if up == True:
        movement[1] -= 5
    if down == True:
        movement[1] += 5

    player = move(sprite_bloc, movement, tiles)

    pygame.draw.rect(screen, White, player)

    for tile in tiles:
        pygame.draw.rect(screen,(255,0,0),tile)

    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
        if event.type == KEYDOWN:
            if event.key == K_d:
                right = True
            if event.key == K_a:
                left = True
            if event.key == K_s:
                down = True
            if event.key == K_w:
                up = True
        if event.type == KEYUP:
            if event.key == K_d:
                right = False
            if event.key == K_a:
                left = False
            if event.key == K_s:
                down = False
            if event.key == K_w:
                up = False
    
    pygame.display.update()
    main_clock.tick(40)