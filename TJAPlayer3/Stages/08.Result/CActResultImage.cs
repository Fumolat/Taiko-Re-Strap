﻿
/*
 * using FDK;

namespace TJAPlayer3
{
	internal class CActResultImage : CActivity
	{
		public override void On活性化()
		{

			base.On活性化();
		}
		public override void On非活性化()
		{
			if (ct登場用 != null)
			{
				ct登場用 = null;
			}
			base.On非活性化();
		}
		public override void OnManagedリソースの作成()
		{
			if (!base.b活性化してない)
			{

				base.OnManagedリソースの作成();
			}
		}
		public override void OnManagedリソースの解放()
		{
			if (!base.b活性化してない)
			{

				base.OnManagedリソースの解放();
			}
		}
		public override unsafe int On進行描画()
		{
			if (b活性化してない)
			{
				return 0;
			}
			if (b初めての進行描画)
			{
				ct登場用 = new CCounter(0, 100, 5, TJAPlayer3.Timer);
				b初めての進行描画 = false;
			}
			ct登場用.t進行();

			if (!ct登場用.b終了値に達した)
			{
				return 0;
			}
			return 1;
		}


		// その他

		#region [ private ]
		//-----------------
		private CCounter ct登場用;
        #endregion

    }
}
*/