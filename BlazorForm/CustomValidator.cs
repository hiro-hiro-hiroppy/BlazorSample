﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorForm
{
    public class CustomValidator : ComponentBase
    {
        private ValidationMessageStore messageStore;
        
        [CascadingParameter]
        private EditContext CurrentEditContext { get; set; }

        protected override void OnInitialized()
        {
            if(this.CurrentEditContext == null)
            {
                throw new InvalidOperationException("コンポーネント作成エラー");
            }

            messageStore = new ValidationMessageStore(CurrentEditContext);
            CurrentEditContext.OnValidationRequested += (s, e) => messageStore.Clear();
            CurrentEditContext.OnFieldChanged += (s, e) => messageStore.Clear(e.FieldIdentifier);
        }

        /// <summary>
        /// 検証メッセージを表示する
        /// </summary>
        /// <param name="errors"></param>
        public void DisplayErrors(Dictionary<string, List<string>>errors)
        {
            foreach(var err in errors)
            {
                messageStore.Add(CurrentEditContext.Field(err.Key), err.Value);
            }

            //カレントコンテンツへ通知する
            CurrentEditContext.NotifyValidationStateChanged();
        }

        /// <summary>
        /// 検証メッセージをクリアする
        /// </summary>
        public void ClearErrors()
        {
            messageStore.Clear();
            //カレントコンテンツへ通知する
            CurrentEditContext.NotifyValidationStateChanged();
        }

    }
}
