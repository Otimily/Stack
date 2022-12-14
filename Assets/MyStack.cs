using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    // 지금 스택에 데이터가 몇개가 들어가 있는지 체크
    public int Count;

    public MyStack(int size)
    {
        // size 크기 만큼 배열을 생성
        // int[] 생성
    }

    // 스택의 사이즈를 초과해서 Push를 하려고 하면 Stack Overflow
    public void Push(int data)
    {

    }

    // 스택에 데이터가 없는데 Pop을 하려고 하면 에러 - Stack is Empty
    public int Pop()
    {
        return 0;
    }

    public void Clear()
    {

    }
}
