Shader "StencilMaskWallPasswordVisibility"
{
	Properties
	{
		[IntRange] _StencilID ("Stencil ID", Range(0, 255)) = 0
	}
	SubShader
	{
		Tags
		{
			"RenderType" = "Opaque"
			"RenderPipeline" = "UniversalPipeline"
		}

		Pass
		{
			Blend Zero One
			ZWrite Off

			Stencil 
			{
				Ref 1
				Comp Always
				Pass Replace
			}
		}
		
		
	}
}