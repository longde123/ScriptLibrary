﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スクロール内の1要素を表すデータクラス
/// </summary>
public class CellDataBase : ICellData
{
    protected Vector2 cellSize;

    
    public CellDataBase(float width, float height)
    {
        cellSize.x = width;
        cellSize.y = height;
    }

    public Vector2 GetCellSize()
    {
        return cellSize;
    }

    public void SetData(ICellData cellData)
    {
        var data = cellData as CellDataBase;
        cellSize = data.cellSize;
    }
}
