using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace BlazorTest.WebApplication1.App
{
    public enum ContentType
    {
        Component,
        Stack,
        Column,
        Row
    }

    public class QuickDockContent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public ContentType Type { get; set; }
        public string HtmlBody { get; set; }
        public bool Active { get; set; }
        //public QuickDockContent Parent { get; set; } = null;
        public List<QuickDockContent> Children { get; set; } = new List<QuickDockContent>();
    }

    public class QuickDockConfig
    {
        public QuickDockInput Input { get; set; } = new QuickDockInput();
        public Rect MainContainerRect { get; set; }

        public List<QuickDockContent> Contents { get; set; } = new List<QuickDockContent>();

        public void SetActive(QuickDockContent target)
        {
            SetActive(Contents, target);
        }

        private void SetActive(List<QuickDockContent> contents, QuickDockContent target)
        {
            contents.ForEach(content =>
            {
                content.Active = content == target;
                SetActive(content.Children, target);
            });
        }
    }

    public class QuickDockInput
    {
        public delegate void MouseEventHandler(UIMouseEventArgs e);

        public event MouseEventHandler MouseMove;

        public event MouseEventHandler MouseUp;

        public void OnMouseMove(UIMouseEventArgs e)
        {
            MouseMove?.Invoke(e);
        }

        public void OnMouseUp(UIMouseEventArgs e)
        {
            MouseUp?.Invoke(e);
        }
    }
}
