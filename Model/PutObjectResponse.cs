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
    /// 上传对象的响应结果。
    /// </summary>
    public class PutObjectResponse : ObsWebServiceResponse
    {
       

        /// <summary>
        /// 对象的ETag校验值。 
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// 对象版本号。
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }


        /// <summary>
        /// 对象存储类型。
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// 对象的全路径。
        /// </summary>
        public string ObjectUrl
        {
            get;
            internal set;
        }

       
    }
}
    
