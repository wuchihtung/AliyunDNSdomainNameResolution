/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDNSSLBSubDomainsResponse : AcsResponse
	{

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<SlbSubDomain> slbSubDomains;

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<SlbSubDomain> SlbSubDomains
		{
			get
			{
				return slbSubDomains;
			}
			set	
			{
				slbSubDomains = value;
			}
		}

		public class SlbSubDomain{

			private string subDomain;

			private long? recordCount;

			private bool? open;

			public string SubDomain
			{
				get
				{
					return subDomain;
				}
				set	
				{
					subDomain = value;
				}
			}

			public long? RecordCount
			{
				get
				{
					return recordCount;
				}
				set	
				{
					recordCount = value;
				}
			}

			public bool? Open
			{
				get
				{
					return open;
				}
				set	
				{
					open = value;
				}
			}
		}
	}
}