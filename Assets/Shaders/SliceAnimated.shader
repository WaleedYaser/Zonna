 Shader "Custome/SlicesAnimated" {
    Properties {
      _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader {
      Tags { "RenderType" = "Opaque" }
      Cull Off
      CGPROGRAM
      #pragma surface surf Lambert vertex:vert
      struct Input {
          float2 uv_MainTex;
          float2 uv_BumpMap;
          float3 worldPos;
      };
      sampler2D _MainTex;
      sampler2D _BumpMap;
      void surf (Input IN, inout SurfaceOutput o) {
          clip (frac((IN.worldPos.y+IN.worldPos.z*0.1) * sin(_Time * 0.05)*0.5) - 0.5);
          o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
      }

	   void vert(inout appdata_full v) {
            v.normal.xyz = v.normal * -1;
        }

      ENDCG
    } 
    Fallback "Diffuse"
  }