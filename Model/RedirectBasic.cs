/*----------------------------------------------------------------------------------
// Copyright 2019 Huawei Technologies Co.,Ltd.
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License.  You may obtain a copy of the
// License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations under the License.
//----------------------------------------------------------------------------------*/

namespace OBS.Model
{
    /// <summary>
    /// 重定向基础配置。
    /// </summary>
    public class RedirectBasic
    {
        

        /// <summary>
        /// 重定向请求时使用的主机名。
        /// </summary>
        /// <remarks>
        /// <para>
        /// 参数可选。
        /// </para>
        /// </remarks>
        public string HostName
        {
            get;
            set;
        }



        /// <summary>
        /// 重定向请求时使用的协议。
        /// </summary>
        /// <remarks>
        /// <para>
        /// 参数可选。
        /// </para>
        /// </remarks>
        public ProtocolEnum? Protocol
        {
            get;
            set;
        }




    }
}
