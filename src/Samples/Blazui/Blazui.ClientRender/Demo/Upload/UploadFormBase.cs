﻿

using Element.ClientRender.Demo.Form;
using Microsoft.AspNetCore.Components;

namespace Element.ClientRender.Demo.Upload
{
    public class UploadFormBase : ComponentBase
    {
        internal LabelAlign formAlign;
        [Inject]
        Element.MessageBox MessageBox { get; set; }

        internal object value;
        protected BForm demoForm;
        protected void Submit()
        {
            if (!demoForm.IsValid())
            {
                return;
            }

            var activity = demoForm.GetValue<UploadActivity>();
            _ = MessageBox.AlertAsync(activity.ToString());
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            value = new UploadActivity()
            {
                Area = Area.Shanghai,
                Name = "测试",
                Previews = new UploadModel[]
                {
                    new UploadModel()
                    {
                         FileName="xxx.jpg",
                          Url="https://www.baidu.com/img/bd_logo1.png"
                    }
                }
            };
        }

        protected void Reset()
        {
            demoForm.Reset();
        }
    }
}
