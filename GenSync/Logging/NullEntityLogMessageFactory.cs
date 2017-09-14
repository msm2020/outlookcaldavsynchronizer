﻿// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer
// Copyright (c) 2015 Alexander Nimmervoll
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

namespace GenSync.Logging
{
  public class NullEntityLogMessageFactory<TAtypeEntity, TBtypeEntity> : IEntityLogMessageFactory<TAtypeEntity, TBtypeEntity>
  {
    public static readonly IEntityLogMessageFactory<TAtypeEntity, TBtypeEntity> Instance = new NullEntityLogMessageFactory<TAtypeEntity, TBtypeEntity>();

    private NullEntityLogMessageFactory()
    {
    }

    public string ACreateOrNull(TAtypeEntity entity)
    {
      return null;
    }

    public string BCreateOrNull(TBtypeEntity entity)
    {
      return null;
    }
  }
}