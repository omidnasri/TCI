using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TCI.Models
{
    /// <summary>
    /// لیست کدهای وضعیت
    /// </summary>
    public enum HttpStatusCode
    {
        /// <summary>
        /// کد وضعیت حذف موفقیت آمیز
        /// </summary>
        [Description(description: "کد وضعیت حذف موفقیت آمیز")]
        Remove_Success = 151,
        /// <summary>
        /// کد وضعیت حذف ناموفق
        /// </summary>
        [Description(description: "کد وضعیت حذف ناموفق")]
        Remove_Failed = 152,
        /// <summary>
        /// کد وضعیت ورودی نامعتبر از سمت کاربر
        /// </summary>
        [Description(description: "کد وضعیت ورودی نامعتبر از سمت کاربر")]
        Input_Invalid = 153,
        /// <summary>
        /// کد وضعیت موفقیت آمیز ایجاد صفحه
        /// </summary>
        [Description(description: "کد وضعیت موفقیت آمیز ایجاد صفحه")]
        Created_Page = 154,
        /// <summary>
        /// کد وضعیت  فعال
        /// </summary>
        [Description(description: "کد وضعیت  فعال")]
        Enable_Status = 155,
        /// <summary>
        /// کد وضعیت غیرفعال
        /// </summary>
        [Description(description: "کد وضعیت غیرفعال")]
        Disable_Status = 156,
        /// <summary>
        /// کد وضعیت ریداریکت
        /// </summary>
        [Description(description: "کد وضعیت ریداریکت")]
        Redirect_To_Page = 157,
        /// <summary>
        /// کد وضعیت ورود غیرموفق
        /// </summary>
        [Description(description: "کد وضعیت ورود غیرموفق")]
        Login_Failed = 159,
        /// <summary>
        /// کد وضعیت ورود موفق
        /// </summary>
        [Description(description: "کد وضعیت ورود موفق")]
        Login_Success = 160,
        /// <summary>
        /// کد وضعیت مصدود شدن
        /// </summary>
        [Description(description: "کد وضعیت مصدود شدن")]
        LockedOut = 161,
        /// <summary>
        /// کد وضعیت تایید بازیابی رمز عبور
        /// </summary>
        [Description(description: "کد وضعیت تایید بازیابی رمز عبور")]
        Forgot_Password_Confirmation = 162
    }
}