﻿// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalDavSynchronizer.DataAccess.HttpClientBasedClient
{
  internal class HttpResponseHeadersAdapter : IHttpHeaders
  {
    private readonly HttpResponseHeaders _inner;

    public HttpResponseHeadersAdapter (HttpResponseHeaders inner)
    {
      if (inner == null)
        throw new ArgumentNullException ("inner");

      _inner = inner;
    }

    public bool TryGetValues (string name, out IEnumerable<string> values)
    {
      return _inner.TryGetValues (name, out values);
    }

    public Uri Location
    {
      get { return _inner.Location; }
    }

    public EntityTagHeaderValue ETag
    {
      get { return _inner.ETag; }
    }
  }
}