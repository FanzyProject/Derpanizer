﻿using System.IO;
using UnityEngine;

public class FileObject : MonoBehaviour
{
    public FileInfo Info;

    public void Init(FileInfo fileInfo)
    {
        Info = fileInfo;
    }

    void OnCollisionStay(Collision collision)
    {
        // TODO add cases for copy, delete, etc
        if (!collision.gameObject.CompareTag("container"))
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            return;
        }
        var directory = collision.gameObject.GetComponent<DirectoryInfo>();
        if (directory != null)
        {
            Info.MoveTo(directory.Name);
        }
    }
}