﻿// -----------------------------------------------------------------------
//  <copyright file="IEventHandlerFactory.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-19 1:27</last-date>
// -----------------------------------------------------------------------

namespace OSharp.EventBus.Handlers
{
    /// <summary>
    /// 定义获取<see cref="IEventHandler"/>实例的方式
    /// </summary>
    public interface IEventHandlerFactory
    {
        /// <summary>
        /// 获取事件处理器实例
        /// </summary>
        /// <returns></returns>
        IEventHandler GetHandler();

        /// <summary>
        /// 释放事件处理器实例
        /// </summary>
        /// <param name="handler"></param>
        void ReleaseHandler(IEventHandler handler);
    }
}