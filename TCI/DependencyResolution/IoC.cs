// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System.Reflection;
using TCI.DataAccess.Context;
using TCI.DataAccess.Interface;
using TCI.DomainService;
using TCI.DomainService.Fiber.Interface;
using TCI.Operation;
using TCI.Operation.Fiber.Interface;

namespace TCI.DependencyResolution
{
    using StructureMap;

    public static class IoC
    {
        public static IContainer Initialize()
        {
            var container = new StructureMap.Container();
            container.Configure(cfg =>
            {
                cfg.Scan(s =>
                {
                    s.WithDefaultConventions();
                    s.Assembly(Assembly.GetAssembly(typeof(BaseOperation<,>)));
                    s.Assembly(Assembly.GetAssembly(typeof(BaseService<>)));
                });
                cfg.For<IFiberUnitOfWork>().Use<FiberContext>();
            });

            return container;
            //new Container(c => c.AddRegistry<DefaultRegistry>());
        }
    }
}