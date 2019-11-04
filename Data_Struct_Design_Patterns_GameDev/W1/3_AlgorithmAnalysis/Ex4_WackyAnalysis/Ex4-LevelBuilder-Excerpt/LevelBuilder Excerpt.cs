// add rows of blocks
Vector2 currentPosition = new Vector2(leftBlockOffset, topRowOffset);
for (int row = 0; row < 3; row++)
{
    for (int column = 0; column < blocksPerRow; column++)
    {
        PlaceBlock(currentPosition);
        currentPosition.x += blockWidth;
    }

    // move to next row
    currentPosition.x = leftBlockOffset;
    currentPosition.y += blockHeight;
}
